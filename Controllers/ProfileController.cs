using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Sky.PlayerInfo.Models;
using Sky.PlayerInfo.Service;

namespace Sky.PlayerInfo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {

        private readonly ILogger<ProfileController> _logger;
        private ProfileServie profileServie;
        private CacheService cacheService;

        public ProfileController(ILogger<ProfileController> logger, ProfileServie profileServie, CacheService cacheService)
        {
            _logger = logger;
            this.profileServie = profileServie;
            this.cacheService = cacheService;
        }

        [HttpGet]
        public async Task<object> Get()
        {
            var full = await profileServie.GetFullResponse("b876ec32e396476ba1158438d83c67d4", "");
            return full;
        }

        [HttpGet]
        [Route("{userId}/{profileId}")]
        public async Task<object> GetProfile(string userId, string profileId)
        {
            Guid.TryParse(profileId, out Guid parsedProfile);
            Guid.TryParse(userId, out Guid parsedUserId);
            Response.ContentType = "application/json"; // the header triggers automatic serialization
            return JsonSerializer.Deserialize<object>(await cacheService.GetProfileJson(parsedUserId, parsedProfile));
        }

        [HttpGet]
        [Route("{userId}/hypixel")]
        public async Task<object> HypixelProfile(string userId, DateTimeOffset maxAge = default)
        {
            Guid.TryParse(userId, out Guid parsedUserId);
            Response.ContentType = "application/json"; // the header triggers automatic serialization
            return await cacheService.GetProfileData(parsedUserId, maxAge);
        }

        [HttpGet]
        [Route("{userId}")]
        public Task<ProfileRoot> GetProfiles(string userId)
        {
            return profileServie.GetProfiles(userId);
        }

        [HttpGet]
        [Route("{userId}/active")]
        public Task<string> GetActiveProfile(string userId)
        {
            return profileServie.GetActiveProfile(userId);
        }

        [HttpGet]
        [Route("{userId}/{profileId}/data")]
        public Task<Data> GetProfileData(string userId, string profileId)
        {
            return profileServie.GetProfileData(userId, profileId);
        }
        [HttpGet]
        [Route("{userId}/{profileId}/data/collections")]
        public async Task<Dictionary<string, CollectionItem>> GetProfileCollections(string userId, string profileId)
        {
            return await profileServie.GetCollections(userId, profileId);
        }
        [HttpGet]
        [Route("{userId}/{profileId}/data/slayers")]
        public async Task<Dictionary<string, SlayerElem>> GetProfileSlayers(string userId, string profileId)
        {
            var data = await profileServie.GetSlayer(userId, profileId);
            return data.Select(c => (c.Key, new SlayerElem() { Level = new SlayerElem.SlayerLvl() { currentLevel = int.Parse(c.Value.claimed_levels.LastOrDefault().Key?.Split('_').LastOrDefault() ?? "0") } })).ToDictionary(c => c.Key, c => c.Item2);
        }

        [HttpGet]
        [Route("{userId}/{profileId}/data/forge")]
        public async Task<ForgeData> GetProfileForge(string userId, string profileId)
        {
            return await profileServie.GetForgeData(userId, profileId);
        }


        public class SlayerElem
        {
            public SlayerLvl Level { get; set; }
            public class SlayerLvl
            {
                public int currentLevel { get; set; }
            }
        }
    }
}
