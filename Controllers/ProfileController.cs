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
        public async Task<Profile> Get()
        {
            var full = await profileServie.GetFullResponse("Technoblade");
            return full.Profiles.First().Value;
        }

        [HttpGet]
        [Route("{userId}")]
        public Task<Root> GetProfiles(string userId)
        {
            return profileServie.GetProfiles(userId);
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
            var data = await profileServie.GetProfileData(userId, profileId);
            return data.Collections;
        }
        [HttpGet]
        [Route("{userId}/{profileId}/data/slayers")]
        public async Task<Slayers> GetProfileSlayers(string userId, string profileId)
        {
            var data = await profileServie.GetProfileData(userId, profileId);
            return data.Slayers;
        }
    }
}
