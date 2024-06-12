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

        IDistributedCache distributedCache;

        public ProfileServie(IDistributedCache distributedCache, IConfiguration config, IProxyApi proxyApi)
        {
            this.distributedCache = distributedCache;
            this.config = config;
            client = new RestClient(config["SKYCRYPT_BASE_URL"]);
            this.proxyApi = proxyApi;
        }

        public async Task<Data> GetProfileData(string playerId, string profileId)
        {
            return await GetOrLoad<Data>(GetKey("data", profileId), playerId);
        }
        public async Task<Dictionary<string, CollectionItem>> GetCollections(string playerId, string profileId)
        {
            var unlockedList = await GetOrLoad<List<string>>(GetKey("collections", profileId), playerId);
            return unlockedList.Select(c => (GetCollectionName(c), // name without level at the end
                 new CollectionItem() { Tier = int.Parse(c.Split('_').Last()) })).GroupBy(c=>c.Item1).ToDictionary(c=>c.Key,c=>c.OrderByDescending(c=>c.Item2.Tier).First().Item2);
        }

        public async Task<Dictionary<string,Coflnet.Sky.PlayerInfo.Models.Hypixel.SlayerBoss>> GetSlayer(string playerId, string profileId)
        {
            var data = await GetOrLoad<Dictionary<string,Coflnet.Sky.PlayerInfo.Models.Hypixel.SlayerBoss>>(GetKey("slayer_boss", profileId), playerId);
            return data;
        }

        private string GetCollectionName(string name)
        {
            // name can have multiple underscores, join all but the last
            return string.Join("_", name.Split('_').Reverse().Skip(1).Reverse());
        }

        public async Task<ProfileRoot> GetProfiles(string playerId)
        {
            var original = await GetOrLoad<Coflnet.Sky.PlayerInfo.Models.Hypixel.Root>("u" + playerId, playerId);
            return new ProfileRoot()
            {
                Profiles = original.profiles.ToDictionary(p => p.profile_id, p => p.cute_name)
            };
        }

        public async Task<string> GetActiveProfile(string playerId)
        {
            var original = await GetOrLoad<Coflnet.Sky.PlayerInfo.Models.Hypixel.Root>("u" + playerId, playerId);
            return original.profiles.Where(p => p.selected).FirstOrDefault().profile_id;
        }

        private async Task GetProfileStats(string uuid)
        {
            var full = await GetFullResponse(uuid);
            foreach (var item in full.profiles)
            {
                Console.WriteLine("Saving " + item.profile_id + " " + JsonSerializer.Serialize(item.members[uuid].slayer?.slayer_bosses));
                await Task.WhenAll(
                    Save(GetKey("items", item.profile_id), JsonSerializer.SerializeToUtf8Bytes(item.members[uuid].item_data)),
                    Save(GetKey("collections", item.profile_id), JsonSerializer.SerializeToUtf8Bytes(item.members[uuid].player_data.unlocked_coll_tiers)),
                    Save(GetKey("slayer_boss", item.profile_id), JsonSerializer.SerializeToUtf8Bytes(item.members[uuid].slayer?.slayer_bosses))
                // Save(GetKey("raw", item.profile_id), JsonSerializer.SerializeToUtf8Bytes(item.Value.Raw))
                );
            }
            await Save("u" + uuid, JsonSerializer.SerializeToUtf8Bytes(full));
        }

        private async Task Save(string key, byte[] data)
        {
            await distributedCache.SetAsync(key, data, new DistributedCacheEntryOptions() { AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(7) });
        }

        private async Task<T> GetOrLoad<T>(string key, string userId)
        {
            var data = await distributedCache.GetAsync(key);
            if (data == null || System.Text.Encoding.UTF8.GetString(data) == "null")
            {
                await GetProfileStats(userId);
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

        public async Task<Coflnet.Sky.PlayerInfo.Models.Hypixel.Root> GetFullResponse(string uuid)
        {
            var response = await proxyApi.ProxyHypixelGetAsync($"/v2/skyblock/profiles?uuid={uuid}");
            Console.WriteLine(response.Truncate(100));
            return JsonSerializer.Deserialize<Coflnet.Sky.PlayerInfo.Models.Hypixel.Root>(JsonSerializer.Deserialize<string>(response));
        }
    }

}