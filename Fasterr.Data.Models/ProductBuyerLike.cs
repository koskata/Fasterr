using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasterr.Data.Models
{
    public class ProductBuyerLike
    {
        public Guid BuyerId { get; set; }

        public ApplicationUser Buyer { get; set; } = null!;

        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;
    }
}
