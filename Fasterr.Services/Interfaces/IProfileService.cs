using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data.Models;
using Fasterr.Web.ViewModels.Product;

namespace Fasterr.Services.Interfaces
{
    public interface IProfileService
    {
        Task<ApplicationUser> GetUserByIdAsync(string userId);

        Task<IEnumerable<ProductAllViewModel>> GetAllLikedProductsByUserAsync(string userId);
    }
}
