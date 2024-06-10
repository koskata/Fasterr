using System.ComponentModel.DataAnnotations;

using static Fasterr.Common.EntityValidationConstants.Product;

namespace Fasterr.Web.ViewModels.Product
{
    public class ProductDetailsViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string ImageURL { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        public int? Discount { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public string Brand { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;
    }
}
