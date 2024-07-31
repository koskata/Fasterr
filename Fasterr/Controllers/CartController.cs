using Fasterr.Services;
using Fasterr.Services.Interfaces;
using Fasterr.Web.Infrastructure;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fasterr.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly IProductService productService;

        public CartController(ICartService _cartService, IProductService _productService)
        {
            cartService = _cartService;
            productService = _productService;
        }

        [Authorize]
        public async Task<IActionResult> Cart()
        {
            string userId = User.GetById();

            var products = await cartService.GetAllProductsInCartAsync(userId);

            return View(products);
        }


        [Authorize]
        public async Task<IActionResult> RemoveFromCart(string id)
        {
            if (!await productService.ProductExistsByIdAsync(id))
            {
                return BadRequest();
            }

            string userId = User.GetById();

            await cartService.RemoveProductFromCartAsync(userId, id);

            return RedirectToAction(nameof(Cart));
        }

        [Authorize]
        public IActionResult Payment()
        {
            return View();
        }
    }
}
