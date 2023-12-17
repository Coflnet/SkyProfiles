using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public ProfileController(ILogger<ProfileController> logger, ProfileServie profileServie)
        {
            _logger = logger;
            this.profileServie = profileServie;
        }

        [HttpGet]
        public async Task<object> Get()
        {
            var full = await profileServie.GetFullResponse("b876ec32e396476ba1158438d83c67d4");
            return full.profiles.First().members;
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
