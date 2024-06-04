using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Fasterr.Data.Models
{
    public class ProductBuyerPurchased
    {
        [Required]
        [Comment("User identifier")]
        public Guid BuyerId { get; set; }

        public ApplicationUser Buyer { get; set; } = null!;

        [Required]
        [Comment("Product identifier")]
        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;
    }
}
