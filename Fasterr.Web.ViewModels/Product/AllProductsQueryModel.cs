using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Web.ViewModels.Enums;

namespace Fasterr.Web.ViewModels.Product
{
    public class AllProductsQueryModel
    {
        public string Category { get; set; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = null!;

        public ProductSorting Sorting { get; set; }

        [Display(Name = "Total Products Count")]
        public int TotalProductsCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<ProductAllViewModel> Products { get; set; } = new List<ProductAllViewModel>();
    }
}
