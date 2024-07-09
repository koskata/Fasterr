using Fasterr.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Fasterr.Controllers
{
    public class UserController : Controller
    {
        private readonly IProfileService profileService;

        public UserController(IProfileService _profileService)
        {
            profileService = _profileService;
        }

        public async Task<IActionResult> ModalContent(string userId)
        {
            if (userId == null)
            {
                return BadRequest();
            }


            var likedProducts = await profileService.GetAllLikedProductsByUserAsync(userId);

            return PartialView("~/Views/Shared/_ModalContent.cshtml", likedProducts);
        }
    }
}
