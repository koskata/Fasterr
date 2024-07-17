using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
            ProductsBuyersRate = new HashSet<ProductBuyerRate>();
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
        [Comment("Product total price with discount")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Comment("Product rating")]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        [Comment("Product brand")]
        public int? BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public virtual Brand? Brand { get; set; }

        [Required]
        [Comment("Product category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        [Required]
        [Comment("Product type identifier")]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public virtual Type Type { get; set; } = null!;

        //public ICollection<ProductBuyerCart> ProductsBuyersCart { get; set; }

        public virtual ICollection<ProductBuyerRate> ProductsBuyersRate { get; set; }
    }
}
