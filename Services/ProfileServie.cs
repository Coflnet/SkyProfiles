using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Coflnet.Sky.Core;
using Coflnet.Sky.Proxy.Client.Api;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Sky.PlayerInfo.Models;

namespace Sky.PlayerInfo.Service
{
    public class ProfileServie
    {
        private RestClient client;
        IConfiguration config;
        private IProxyApi proxyApi;
        private CacheService cacheService;

        IDistributedCache distributedCache;

        public ProfileServie(IDistributedCache distributedCache, IConfiguration config, IProxyApi proxyApi, CacheService cacheService)
        {
            this.distributedCache = distributedCache;
            this.config = config;
            client = new RestClient(config["SKYCRYPT_BASE_URL"]);
            this.proxyApi = proxyApi;
            this.cacheService = cacheService;
        }

        public async Task<Data> GetProfileData(string playerId, string profileId)
        {
            profileId = await MapProfileId(playerId, profileId);
            return await GetOrLoad<Data>(GetKey("data", profileId), playerId, profileId);
        }
        public async Task<Dictionary<string, CollectionItem>> GetCollections(string playerId, string profileId)
        {
            profileId = await MapProfileId(playerId, profileId);
            var unlockedList = await GetOrLoad<List<string>>(GetKey("collections", profileId), playerId, profileId);
            return ConvertCollections(unlockedList);
        }

        private Dictionary<string, CollectionItem> ConvertCollections(List<string> unlockedList)
        {
            return unlockedList.Select(c => (GetCollectionName(c), // name without level at the end
                 new CollectionItem() { Tier = int.Parse(c.Split('_').Last()) })).GroupBy(c => c.Item1).ToDictionary(c => c.Key, c => c.OrderByDescending(c => c.Item2.Tier).First().Item2);
        }

        public async Task<Dictionary<string, Coflnet.Sky.PlayerInfo.Models.Hypixel.SlayerBoss>> GetSlayer(string playerId, string profileId)
        {
            profileId = await MapProfileId(playerId, profileId);
            var data = await GetOrLoad<Dictionary<string, Coflnet.Sky.PlayerInfo.Models.Hypixel.SlayerBoss>>(GetKey("slayer_boss", profileId), playerId, profileId);
            return data;
        }

        private string GetCollectionName(string name)
        {
            // name can have multiple underscores, join all but the last
            return string.Join("_", name.Split('_').Reverse().Skip(1).Reverse());
        }

        public async Task<ProfileRoot> GetProfiles(string playerId, DateTimeOffset maxAge = default)
        {
            var hypixelResponse = await cacheService.GetProfileData(Guid.Parse(playerId), maxAge);
            try
            {
                var root = new ProfileRoot();
                foreach (var profile in hypixelResponse.stats.SkyBlock.profiles)
                {
                    root.Profiles.Add(profile.Value.cute_name, profile.Value.profile_id);
                }
                return root;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(JsonSerializer.Serialize(hypixelResponse));
                return new ProfileRoot();
            }
        }

        public async Task<string> GetActiveProfile(string playerId)
        {
            return await cacheService.GetActiveProfile(playerId);
        }

        private async Task<string> MapProfileId(string playerId, string profileId)
        {
            if (string.IsNullOrEmpty(profileId) || profileId == "current")
            {
                return await GetActiveProfile(playerId);
            }
            return profileId;
        }

        private async Task GetProfileStats(string uuid, string profileId)
        {
            var memberProfile = await GetFullResponse(uuid, profileId);
            Console.WriteLine("Saving " + profileId + " " + JsonSerializer.Serialize(memberProfile.slayer?.slayer_bosses ?? new()));
            await Task.WhenAll(
                Save(GetKey("items", profileId), JsonSerializer.SerializeToUtf8Bytes(memberProfile.item_data)),
                Save(GetKey("collections", profileId), JsonSerializer.SerializeToUtf8Bytes(memberProfile.player_data.unlocked_coll_tiers)),
                Save(GetKey("slayer_boss", profileId), JsonSerializer.SerializeToUtf8Bytes(memberProfile.slayer?.slayer_bosses ?? new())),
                Save(GetKey("forge", profileId), JsonSerializer.SerializeToUtf8Bytes(GetForgeDetails(memberProfile)))
            // Save(GetKey("raw", item.profile_id), JsonSerializer.SerializeToUtf8Bytes(item.Value.Raw))
            );
        }

        private ForgeData GetForgeDetails(Coflnet.Sky.PlayerInfo.Models.Hypixel.Member member)
        {
            var data = new ForgeData();
            var collections = ConvertCollections(member.player_data.unlocked_coll_tiers).ToDictionary(c => c.Key, c => (int)c.Value.Tier);
            var expRequired = 0;
            foreach (var item in MappingConstants.HotMexpToLevel)
            {
                if (expRequired + item.Value > member.mining_core?.experience)
                {
                    data.HotMLevel = item.Key - 1;
                    break;
                }
                expRequired += item.Value;
            }
            Console.WriteLine($"HotMLevel {data.HotMLevel} {member.mining_core?.experience}");
            //data.HotMLevel = MappingConstants.HotMexpToLevel.Where(c => member.mining_core?.experience >= c.Value).Select(c=>c.Key).DefaultIfEmpty(0).Max(c => c);
            if (member.mining_core?.nodes?.forge_time != null && member.mining_core.nodes.forge_time <= 20)
                data.QuickForgeSpeed = MappingConstants.QuickForgeToPercent[member.mining_core.nodes.forge_time.Value];
            data.CollectionLevels = collections;
            return data;
        }

        private async Task Save(string key, byte[] data)
        {
            await distributedCache.SetAsync(key, data, new DistributedCacheEntryOptions() { AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(7) });
        }

        public async Task<ForgeData> GetForgeData(string playerId, string profileId)
        {
            profileId = await MapProfileId(playerId, profileId);
            return await GetOrLoad<ForgeData>(GetKey("forge", profileId), playerId, profileId);
        }

        private async Task<T> GetOrLoad<T>(string key, string userId, string profileId)
        {
            var data = await distributedCache.GetAsync(key);
            if (data == null || System.Text.Encoding.UTF8.GetString(data) == "null")
            {
                await GetProfileStats(userId, profileId);
                data = await distributedCache.GetAsync(key);
            }
            Console.WriteLine($"loaded {key} {System.Text.Encoding.UTF8.GetString(data).Truncate(100)}");
            return JsonSerializer.Deserialize<T>(data, new JsonSerializerOptions()
            {
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
            });
        }

        private static string GetKey(string part, string profileId)
        {
            return "p" + part + profileId;
        }

        public async Task<Coflnet.Sky.PlayerInfo.Models.Hypixel.Member> GetFullResponse(string uuid, string profileId)
        {
            Guid.TryParse(profileId, out var guid);
            var response = await cacheService.GetProfileJson(Guid.Parse(uuid), guid, DateTime.UtcNow.AddDays(-7));
            return JsonSerializer.Deserialize<Coflnet.Sky.PlayerInfo.Models.Hypixel.Member>(response);
        }
    }

    public class ForgeData
    {
        public int HotMLevel { get; set; }
        public float QuickForgeSpeed { get; set; }
        public Dictionary<string, int> CollectionLevels { get; set; }
    }

    public class MappingConstants
    {
        public static Dictionary<int, int> HotMexpToLevel = new(){
            {1, 0},
            {2, 3000},
            {3, 9000},
            {4, 25000},
            {5, 60000},
            {6, 100000},
            {7, 150000},
            {8, 210000},
            {9, 290000},
            {10, 400000},
        };

        public static Dictionary<int, float> QuickForgeToPercent = new(){
            {1, 0.895f},
            {2, 0.89f},
            {3, 0.885f},
            {4, 0.88f},
            {5, 0.875f},
            {6, 0.87f},
            {7, 0.865f},
            {8, 0.86f},
            {9, 0.855f},
            {10, 0.85f},
            {11, 0.845f},
            {12, 0.84f},
            {13, 0.835f},
            {14, 0.83f},
            {15, 0.825f},
            {16, 0.82f},
            {17, 0.815f},
            {18, 0.81f},
            {19, 0.805f},
            {20, 0.7f}
        };
    }
}