using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fasterr.Data.Configuration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category() 
                {
                    Id = 1,
                    Name = "Shoes"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Kits"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Tracksuits"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Thermal underwear"
                }
            };

            return categories.ToArray();
        }
    }
}
