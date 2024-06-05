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
    public class BrandEntityConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(GenerateBrands());
        }

        private Brand[] GenerateBrands()
        {
            List<Brand> brands = new List<Brand>()
            {
                new Brand()
                {
                    Id = 1,
                    Name = "Nike"
                },
                new Brand()
                {
                    Id = 2,
                    Name = "Adidas"
                },
                new Brand()
                {
                    Id = 3,
                    Name = "Under Armour"
                },
                new Brand()
                {
                    Id = 4,
                    Name = "Puma"
                },
                new Brand() 
                {
                    Id = 5,
                    Name = "Reebok"
                }
            };

            return brands.ToArray();
        }
    }
}
