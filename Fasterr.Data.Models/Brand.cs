using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using static Fasterr.Common.EntityValidationConstants.Brand;

namespace Fasterr.Data.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Brand name")]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;
    }
}
