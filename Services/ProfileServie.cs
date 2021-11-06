using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using RestSharp;
using Sky.PlayerInfo.Models;

namespace Sky.PlayerInfo.Service
{
    public class ProfileServie
    {
        private static RestClient client = new RestClient("https://sky.shiiyu.moe/api/v2");

        IDistributedCache distributedCache;

        public ProfileServie(IDistributedCache distributedCache)
        {
            this.distributedCache = distributedCache;
        }

        public async Task<Data> GetProfileData(string playerId, string profileId)
        {
            return await GetOrLoad<Data>(GetKey("data", profileId), playerId);
        }

        public async Task<Root> GetProfiles(string playerId)
        {
            return await GetOrLoad<Root>("u" + playerId, playerId);
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
            return JsonSerializer.Deserialize<T>(data);
        }

        private static string GetKey(string part, string profileId)
        {
            return "p" + part + profileId;
        }

        public async Task<Root> GetFullResponse(string uuid)
        {
            var response = await client.ExecuteAsync(new RestRequest($"/profile/{uuid}"));
            Console.WriteLine(response.Content);
            return JsonSerializer.Deserialize<Root>(response.Content);
        }
    }

}