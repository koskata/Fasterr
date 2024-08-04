using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data.Models;
using Fasterr.Web.ViewModels.Product;

namespace Fasterr.Services.Interfaces
{
    public interface ICartService
    {
        Task<List<ProductAllViewModel>> GetAllProductsInCartAsync(string userId);

        Task RemoveProductFromCartAsync(string userId, string productId);

        Task CleanAndMoveToPurchasedAllProductsFromUserCartAsync(string userId);

        Task MoveProductsToPurchasedAsync(string userId);
    }
}
