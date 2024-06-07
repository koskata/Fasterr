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
    }
}
