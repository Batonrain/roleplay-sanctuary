using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using RoleplaySanctuary.Settings;

namespace RoleplaySanctuary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VkAuthController : ControllerBase
    {
        private readonly VkSettings _settings;

        public VkAuthController(IOptions<VkSettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet(Name = "reciever")]
        public async Task RecieveCode(string code)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://oauth.vk.com/access_token?client_id={_settings.ClientId}&client_secret={_settings.ClientSecret}&redirect_uri={_settings.RedirectUri}&code={code}");

                var content = await response.Content.ReadAsStringAsync();

                //var result = JObject.Parse(content);
            }
        }
    }
}
