using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasterr.Web.ViewModels.Product
{
    public class ProductQueryServiceModel
    {
        public int TotalProductsCount { get; set; }

        public IEnumerable<ProductAllViewModel> Products { get; set; } = new List<ProductAllViewModel>();
    }
}
