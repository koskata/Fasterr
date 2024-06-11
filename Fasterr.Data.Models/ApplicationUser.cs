using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using static Fasterr.Common.EntityValidationConstants.ApplicationUser;

namespace Fasterr.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Cart = new HashSet<ProductBuyerCart>();
            PurchasedProducts = new HashSet<ProductBuyerPurchased>();
            ProductsBuyersRate = new HashSet<ProductBuyerRate>();
        }

        [Required]
        [Comment("User first name")]
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("User last name")]
        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;

        public virtual ICollection<ProductBuyerCart> Cart { get; set; }

        public virtual ICollection<ProductBuyerPurchased> PurchasedProducts { get; set; }

        public virtual ICollection<ProductBuyerRate> ProductsBuyersRate { get; set; }
    }
}
