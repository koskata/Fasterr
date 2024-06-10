using Fasterr.Services.Interfaces;
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

        public async Task<IActionResult> All(string type)
        {
            List<ProductAllViewModel> products;
            
            if (type == "man")
            {
                products = await productService.GetAllManProductsAsync();
            }
            else
            {
                products = await productService.GetAllWomanProductsAsync();
            }

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
