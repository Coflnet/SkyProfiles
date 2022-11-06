using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
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

        IDistributedCache distributedCache;

        public ProfileServie(IDistributedCache distributedCache, IConfiguration config)
        {
            this.distributedCache = distributedCache;
            this.config = config;
            client = new RestClient(config["SKYCRYPT_BASE_URL"]);
        }

        public async Task<Data> GetProfileData(string playerId, string profileId)
        {
            return await GetOrLoad<Data>(GetKey("data", profileId), playerId);
        }

        public async Task<Root> GetProfiles(string playerId)
        {
            return await GetOrLoad<Root>("u" + playerId, playerId);
        }

        public async Task<string> GetActiveProfile(string playerId)
        {
            var root = await GetProfiles(playerId);
            return root.Profiles.Where(p => p.Value.Current).FirstOrDefault().Key;
        }

        private async Task GetProfileStats(string uuid)
        {
            var full = await GetFullResponse(uuid);
            foreach (var item in full.Profiles)
            {
                await Task.WhenAll(
                    Save(GetKey("items", item.Key), JsonSerializer.SerializeToUtf8Bytes(item.Value.Items)),
                    Save(GetKey("data", item.Key), JsonSerializer.SerializeToUtf8Bytes(item.Value.Data)),
                    Save(GetKey("raw", item.Key), JsonSerializer.SerializeToUtf8Bytes(item.Value.Raw)));
                item.Value.Raw = null;
                item.Value.Items = null;
                item.Value.Data = null;
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
            if (data == null)
            {
                await GetProfileStats(userId);
                data = await distributedCache.GetAsync(key);
            }
            return JsonSerializer.Deserialize<T>(data, new JsonSerializerOptions()
            {
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
            });
        }

        private static string GetKey(string part, string profileId)
        {
            return "p" + part + profileId;
        }

        public async Task<Root> GetFullResponse(string uuid)
        {
            var response = await client.ExecuteAsync(new RestRequest($"api/v2/profile/{uuid}"));
            return JsonSerializer.Deserialize<Root>(response.Content);
        }
    }

}