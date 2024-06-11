using Fasterr.Services.Interfaces;
using Fasterr.Web.Infrastructure;
using Fasterr.Web.ViewModels.Product;

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
            query.Products = queryResult.Products;

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


        [HttpPost]
        public async Task<IActionResult> GiveRating(string id, string star)
        {
            int rating = int.Parse(star);

            if (!await productService.ProductExistsByIdAsync(id))
            {
                return BadRequest();
            }

            var model = await productService.GetProductByIdAsync(id);

            string userId = User.GetById();

            await productService.Rate(model, id, rating, userId);

            return RedirectToAction(nameof(Info), new { id = id });
        }
    }
}
