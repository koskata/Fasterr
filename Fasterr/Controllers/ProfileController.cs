using Fasterr.Services.Interfaces;
using Fasterr.Web.Infrastructure;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fasterr.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IProfileService profileService;
        

        public ProfileController(IProfileService _profileService)
        {
            profileService = _profileService;
        }

        public async Task<IActionResult> Info()
        {
            string userId = User.GetById();
            var user = await profileService.GetUserByIdAsync(userId);

            return View(user);
        }
    }
}
