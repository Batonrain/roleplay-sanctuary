using Microsoft.AspNetCore.Mvc;
using RoleplaySanctuary.Domain.Models.ViewModels;
using RoleplaySanctuary.Domain.Services.Interfaces;

namespace RoleplaySanctuary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IUserRegistrationService _userRegistrationService;

        public RegistrationController(
            IUserRegistrationService userRegistrationService)
        {
            _userRegistrationService = userRegistrationService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userRegistrationService.RegisterNewUser(model);

                if(result != 0)
                {
                    return Ok(new { message = "Registration successful" });
                }
            }

            return BadRequest(new { message = "Invalid model data" });
        }
    }
}
