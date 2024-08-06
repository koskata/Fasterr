using Fasterr.Services;
using Fasterr.Services.Interfaces;
using Fasterr.Web.Infrastructure;
using Fasterr.Web.ViewModels.Cart;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static Fasterr.Common.MessageConstants;

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
        public IActionResult Payment(decimal totalSum)
        {
            if (totalSum == 0.0m)
            {
                return RedirectToAction(nameof(Cart));
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> PayWithCard()
        {
            string userId = User.GetById();

            var products = await cartService.GetAllProductsInCartAsync(userId);

            decimal? totalAmount = 0.0m;
            foreach (var product in products)
            {
                decimal? discount = product.Discount / 100;
                decimal? discount2 = product.Price * discount;
                decimal? priceWithDiscount = product.Price - discount2;

                totalAmount += priceWithDiscount;
            }

            PayWithCardViewModel model = new();
            model.TotalAmount = totalAmount;

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> PayWithCash()
        {
            string userId = User.GetById();

            var products = await cartService.GetAllProductsInCartAsync(userId);

            decimal? totalAmount = 0.0m;
            foreach (var product in products)
            {
                decimal? discount = product.Discount / 100;
                decimal? discount2 = product.Price * discount;
                decimal? priceWithDiscount = product.Price - discount2;

                totalAmount += priceWithDiscount;
            }

            PayWithCashViewModel model = new();
            model.TotalAmount = totalAmount;

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> CleanCart()
        {
            string userId = User.GetById();

            await cartService.CleanAndMoveToPurchasedAllProductsFromUserCartAsync(userId);

            TempData[UserMessageSuccess] = "Successfully made purchase!";

            return RedirectToAction("Index", "Home");
        }
    }
}
