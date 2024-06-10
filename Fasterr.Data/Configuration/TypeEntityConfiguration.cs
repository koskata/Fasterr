using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fasterr.Data.Configuration
{
    public class TypeEntityConfiguration : IEntityTypeConfiguration<Fasterr.Data.Models.Type>
    {
        public void Configure(EntityTypeBuilder<Models.Type> builder)
        {
            builder.HasData(GenerateTypes());
        }

        private Models.Type[] GenerateTypes()
        {
            List<Models.Type> types = new List<Models.Type>()
            {
                new Models.Type
                {
                    Id = 1,
                    Name = "Man"
                },
                new Models.Type
                {
                    Id = 2,
                    Name = "Women"
                }
            };

            return types.ToArray();
        }
    }
}
