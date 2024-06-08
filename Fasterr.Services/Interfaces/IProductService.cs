using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Web.ViewModels.Product;

namespace Fasterr.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductAllViewModel>> GetAllProductsAsync();

        Task<ProductDetailsViewModel> GetProductByIdAsync(string id);

        Task<bool> ProductExistsByIdAsync(string id);
    }
}
