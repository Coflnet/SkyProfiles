using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Data.Linq;
using Cassandra.Mapping;
using Coflnet.Sky.PlayerInfo.Models.Hypixel;
using Coflnet.Sky.Proxy.Client.Api;
using Microsoft.Extensions.Configuration;

namespace Sky.PlayerInfo.Service;
public class CacheService
{
    private IConfiguration config;
    private IProxyApi proxyApi;
    Table<ProfileEntry> profiles;
    Table<ActiveProfile> activeProfiles;
    Table<HypixelProfile> hypixelProfiles;
    Table<MuseumProfile> museumProfiles;

    public CacheService(IConfiguration config, IProxyApi proxyApi, ISession session)
    {
        this.config = config;
        this.proxyApi = proxyApi;

        var mapping = new MappingConfiguration().Define(
                new Map<ProfileEntry>()
                .PartitionKey(p => p.ProfileId)
                .ClusteringKey(p => p.Part, SortOrder.Descending)
                .ClusteringKey(p => p.LastChange, SortOrder.Descending));

        profiles = new Table<ProfileEntry>(session, mapping, "hypixel_skyblock_profiles");

        var activeMapping = new MappingConfiguration().Define(
                new Map<ActiveProfile>()
                .PartitionKey(p => p.PlayerId)
                .ClusteringKey(p => p.LastChange, SortOrder.Descending)
                .Column(p => p.ProfileId));

        activeProfiles = new Table<ActiveProfile>(session, activeMapping, "active_player_profiles");

        var hypixelMapping = new MappingConfiguration().Define(
                new Map<HypixelProfile>()
                .PartitionKey(p => p.PlayerId)
                .ClusteringKey(p => p.LastLogout, SortOrder.Descending)
                .Column(p => p.Content));

        hypixelProfiles = new Table<HypixelProfile>(session, hypixelMapping, "hypixel_player_profiles");

        var museumMapping = new MappingConfiguration().Define(
                new Map<MuseumProfile>()
                .PartitionKey(p => p.ProfileId)
                .ClusteringKey(p => p.PlayerId)
                .ClusteringKey(p => p.SavedAt, SortOrder.Descending)
                .Column(p => p.Content));

        museumProfiles = new Table<MuseumProfile>(session, museumMapping, "hypixel_museum");

        museumProfiles.CreateIfNotExists();
        hypixelProfiles.CreateIfNotExists();
        activeProfiles.CreateIfNotExists();
        profiles.CreateIfNotExists();
    }


    public async Task<string> GetProfileJson(Guid playerId, Guid profileId, DateTimeOffset maxAge = default)
    {
        if (profileId == Guid.Empty)
        {
            var activeProfile = await activeProfiles.Where(p => p.PlayerId == playerId).FirstOrDefault().ExecuteAsync();
            if (activeProfile != null)
            {
                profileId = activeProfile.ProfileId;
                Console.WriteLine($"Using active profile {profileId}");
            }
        }
        var entry = await profiles.Where(p => p.ProfileId == profileId && p.Part == playerId && p.LastChange > maxAge).FirstOrDefault().ExecuteAsync();
        if (entry == null)
        {
            if (playerId == Guid.Empty)
            {
                return null;
            }
            var response = await GetResponseForPlayer(playerId.ToString());
            var members = JsonSerializer.Deserialize<ProfileResponse>(response);
            foreach (var profile in members.profiles)
            {
                foreach (var member in profile.members)
                {
                    var playerData = JsonSerializer.Serialize(member.Value);
                    DateTimeOffset lastChange = GetHighestTimestamp(playerData);
                    var playerProfile = new ProfileEntry()
                    {
                        ProfileId = profile.profile_id,
                        Part = Guid.Parse(member.Key),
                        Data = playerData,
                        LastChange = lastChange,
                        SavedAt = DateTime.UtcNow
                    };
                    await profiles.Insert(playerProfile).ExecuteAsync();
                }
            }
            var generalInfo = JsonSerializer.Deserialize<Root>(response);
            foreach (var profile in generalInfo.profiles)
            {
                foreach (var member in profile.members.Keys)
                {
                    profile.members[member] = null;
                }
                var serializedProfile = JsonSerializer.Serialize(profile);
                var overallEntry = new ProfileEntry()
                {
                    ProfileId = Guid.Parse(profile.profile_id),
                    Part = Guid.Empty,
                    Data = serializedProfile,
                    LastChange = GetHighestTimestamp(serializedProfile),
                    SavedAt = DateTime.UtcNow
                };
                await profiles.Insert(overallEntry).ExecuteAsync();
            }
            var selected = generalInfo.profiles.Where(p => p.selected).FirstOrDefault();
            if (selected != null)
            {
                // update active profile user has selected (currently playing on)
                await activeProfiles.Insert(new ActiveProfile()
                {
                    PlayerId = playerId,
                    ProfileId = Guid.Parse(selected.profile_id),
                    LastChange = DateTime.UtcNow
                }).ExecuteAsync();
                if (profileId == Guid.Empty)
                {
                    profileId = Guid.Parse(selected.profile_id);
                }
            }
            entry = await profiles.Where(p => p.ProfileId == profileId && p.Part == playerId).FirstOrDefault().ExecuteAsync();
        }
        return entry.Data;
    }

    private static DateTimeOffset GetHighestTimestamp(string playerData)
    {
        var timestamps = Regex.Matches(playerData, "\"timestamp\":(\\d+)").Select(t => long.Parse(t.Groups[1].Value));
        var lastChange = DateTimeOffset.FromUnixTimeMilliseconds(timestamps.DefaultIfEmpty(0).Max());
        return lastChange;
    }

    public async Task<Coflnet.Sky.PlayerInfo.Models.HypixelProfile.Player> GetProfileData(Guid playerId, DateTimeOffset maxAge = default)
    {
        var latest = await hypixelProfiles.Where(p => p.PlayerId == playerId).FirstOrDefault().ExecuteAsync();
        if (latest != null && latest.LastLogout > maxAge)
        {
            return JsonSerializer.Deserialize<Coflnet.Sky.PlayerInfo.Models.HypixelProfile.Root>(latest.Content).player;
        }
        var response = await Proxy($"/v2/player?uuid={playerId}");
        var profile = JsonSerializer.Deserialize<Coflnet.Sky.PlayerInfo.Models.HypixelProfile.Root>(response);
        await hypixelProfiles.Insert(new HypixelProfile()
        {
            PlayerId = playerId,
            LastLogout = DateTimeOffset.FromUnixTimeMilliseconds(profile.player.lastLogout),
            Content = response
        }).ExecuteAsync();
        return profile.player;
    }

    private async Task<string> GetResponseForPlayer(string playerId)
    {
        var response = await Proxy($"/v2/skyblock/profiles?uuid={playerId}");
        return response;
    }

    private async Task<string> Proxy(string path)
    {
        return JsonSerializer.Deserialize<string>(await proxyApi.ProxyHypixelGetAsync(path));
    }

    internal async Task<string> GetActiveProfile(string playerId)
    {
        var activeProfile = activeProfiles.Where(p => p.PlayerId == Guid.Parse(playerId)).FirstOrDefault().Execute();
        if (activeProfile == null)
        {
            await GetProfileJson(Guid.Parse(playerId), Guid.Empty);
            activeProfile = activeProfiles.Where(p => p.PlayerId == Guid.Parse(playerId)).FirstOrDefault().Execute();
        }
        return activeProfile.ProfileId.ToString();
    }

    internal async Task<Models.Museum.Player> GetMuseum(Guid parsedUserId, Guid parsedProfile, DateTimeOffset after)
    {
        var profile = await museumProfiles.Where(p => p.ProfileId == parsedProfile && p.PlayerId == parsedUserId && p.SavedAt > after).FirstOrDefault().ExecuteAsync();
        if (profile != null)
        {
            return JsonSerializer.Deserialize<Models.Museum.Player>(profile.Content);
        }
        var response = await Proxy($"/v2/skyblock/museum?profile={parsedProfile:n}");
        var parsed = JsonSerializer.Deserialize<Models.Museum.MuseumRoot>(response);
        var player = parsed.members.FirstOrDefault(p => p.Key == parsedUserId.ToString("n"));
        foreach (var item in parsed.members)
        {
            var playerData = JsonSerializer.Serialize(item.Value);
            var playerProfile = new MuseumProfile()
            {
                ProfileId = parsedProfile,
                PlayerId = Guid.Parse(item.Key),
                Content = playerData,
                SavedAt = DateTimeOffset.UtcNow
            };
            var insert = museumProfiles.Insert(playerProfile);
            insert.SetTTL(60 * 60 * 24 * 7);
            await insert.ExecuteAsync();
        }
        return player.Value;
    }

    public class ProfileEntry
    {
        public Guid ProfileId { get; set; }
        /// <summary>
        /// Highest timestamp in the response object
        /// </summary>
        public DateTimeOffset LastChange { get; set; }
        public DateTimeOffset SavedAt { get; set; }
        /// <summary>
        /// The the uuid of the member or profile (containing  banking, community_upgrades, cute_name)
        /// </summary>
        public Guid Part { get; set; }
        public string Data { get; set; }
    }

    public class ActiveProfile
    {
        public Guid PlayerId { get; set; }
        public Guid ProfileId { get; set; }
        public DateTime LastChange { get; set; }
    }

    public class ProfileResponse
    {
        [JsonPropertyName("profiles")]
        public List<SingleProfile> profiles { get; set; }
    }

    public class SingleProfile
    {
        [JsonPropertyName("profile_id")]
        public Guid profile_id { get; set; }
        [JsonPropertyName("members")]
        public Dictionary<string, object> members { get; set; }
    }

    public class HypixelProfile
    {
        public Guid PlayerId { get; set; }
        public DateTimeOffset LastLogout { get; set; }
        public string Content { get; set; }
    }

    public class MuseumProfile
    {
        public Guid ProfileId { get; set; }
        public Guid PlayerId { get; set; }
        public DateTimeOffset SavedAt { get; set; }
        public string Content { get; set; }
    }
}
