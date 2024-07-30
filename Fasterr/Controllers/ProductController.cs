using Fasterr.Services.Interfaces;
using Fasterr.Web.Infrastructure;
using Fasterr.Web.ViewModels.Product;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fasterr.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        public async Task<IActionResult> AllForMen([FromQuery] AllProductsQueryModel query /*string type*/)
        {

            var queryResult = await productService.GetAllProductsAsync(
                query.Category,
                query.SearchTerm,
                query.Sorting);

            query.TotalProductsCount = queryResult.TotalProductsCount;
            query.Products = queryResult.Products.Where(x => x.Type == "Man");

            var productCategories = await productService.AllCategoriesNamesAsync();
            query.Categories = productCategories;

            return View(query);
        }

        public async Task<IActionResult> AllForWomen([FromQuery] AllProductsQueryModel query /*string type*/)
        {

            var queryResult = await productService.GetAllProductsAsync(
                query.Category,
                query.SearchTerm,
                query.Sorting);

            query.TotalProductsCount = queryResult.TotalProductsCount;
            query.Products = queryResult.Products.Where(x => x.Type == "Women");

            var productCategories = await productService.AllCategoriesNamesAsync();
            query.Categories = productCategories;

            return View(query);
        }

        public async Task<IActionResult> AllDiscount([FromQuery] AllProductsQueryModel query)
        {
            var queryResult = await productService.GetAllProductsAsync(
                query.Category,
                query.SearchTerm,
                query.Sorting);

            query.TotalProductsCount = queryResult.TotalProductsCount;
            query.Products = queryResult.Products.Where(x => x.Discount > 0.0m);

            var productCategories = await productService.AllCategoriesNamesAsync();
            query.Categories = productCategories;

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> Info(string id)
        {
            if (!await productService.ProductExistsByIdAsync(id))
            {
                return BadRequest();
            }

            var model = await productService.GetProductByIdAsync(id);

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> GiveRating(string id, string star)
        {
            if (star == null)
            {
                return RedirectToAction(nameof(Info), new { id = id });
            }

            int rating = int.Parse(star);

            if (!await productService.ProductExistsByIdAsync(id))
            {
                return BadRequest();
            }

            var model = await productService.GetProductByIdAsync(id);

            string userId = User.GetById();

            bool isAny = await productService.RateAsync(model, id, rating, userId);

            if (isAny)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Info), new { id = id });
        }

        [Authorize]
        public async Task<IActionResult> Like(string id)
        {
            if (!await productService.ProductExistsByIdAsync(id))
            {
                return BadRequest();
            }

            string userId = User.GetById();

            var model = await productService.GetProductByIdAsync(id);

            bool isAny = await productService.LikeAsync(model, id, userId);

            return RedirectToAction(nameof(Info), new { id = id });
        }

        [Authorize]
        public async Task<IActionResult> AddToCart(string id)
        {
            if (!await productService.ProductExistsByIdAsync(id))
            {
                return BadRequest();
            }

            var model = await productService.GetProductByIdAsync(id);

            var userId = User.GetById();

            await productService.AddToCartAsync(model, id, userId);

            return RedirectToAction(nameof(Cart), "Product");
        }

        [Authorize]
        public async Task<IActionResult> Cart()
        {
            string userId = User.GetById();

            var products = await productService.GetAllProductsInCartAsync(userId);

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

            await productService.RemoveProductFromCartAsync(userId, id);

            return RedirectToAction(nameof(Cart));
        }

        [Authorize]
        public IActionResult Payment()
        {
            return View();
        }
    }
}
