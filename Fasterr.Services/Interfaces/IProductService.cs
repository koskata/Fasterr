using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Web.ViewModels.Enums;
using Fasterr.Web.ViewModels.Product;

namespace Fasterr.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductQueryServiceModel> GetAllProductsAsync(string category = null,
                                                                               string searchTerm = null,
                                                                               ProductSorting sorting = ProductSorting.HighestRating);

        Task<ProductDetailsViewModel> GetProductByIdAsync(string id);

        Task<bool> ProductExistsByIdAsync(string id);

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task Rate(ProductDetailsViewModel model, string productId, int rating, string userId);
    }
}
