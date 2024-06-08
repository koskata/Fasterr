using Fasterr.Services.Interfaces;

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

        public async Task<IActionResult> All()
        {
            var products = await productService.GetAllProductsAsync();

            return View(products);
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
    }
}
