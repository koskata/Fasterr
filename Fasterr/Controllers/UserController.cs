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

        public async Task<IActionResult> LikedProducts(string userId)
        {
            if (userId == null)
            {
                return BadRequest();
            }


            var likedProducts = await profileService.GetAllLikedProductsByUserAsync(userId);

            return PartialView("~/Views/Shared/_LikedProductsPartialView.cshtml", likedProducts);
        }

        public async Task<IActionResult> PurchasedProducts(string userId)
        {
            if (userId == null)
            {
                return BadRequest();
            }


            var purchasedProducts = await profileService.GetAllPurchasedProductsByUserAsync(userId);

            return PartialView("~/Views/Shared/_PurchasedProductsPartialView.cshtml", purchasedProducts);
        }
    }
}
