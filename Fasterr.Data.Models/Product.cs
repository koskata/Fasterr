using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using static Fasterr.Common.EntityValidationConstants.Product;

namespace Fasterr.Data.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
            //ProductsBuyersCart = new HashSet<ProductBuyerCart>();
        }

        [Key]
        [Comment("Product identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Product name")]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Product description")]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Product image")]
        public string ImageURL { get; set; } = string.Empty;

        [Required]
        [Comment("Product price")]
        public decimal Price { get; set; }

        [Comment("Product price discount")]
        public int? Discount { get; set; }

        [Required]
        [Comment("Product rating")]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        [Comment("Product brand")]
        public int? BrandId { get; set; }

        public virtual Brand? Brand { get; set; }

        [Required]
        [Comment("Product category identifier")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

        //public ICollection<ProductBuyerCart> ProductsBuyersCart { get; set; }
    }
}
