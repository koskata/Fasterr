using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasterr.Common
{
    public static class EntityValidationConstants
    {
        public static class ApplicationUser
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 25;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 25;
        }

        public static class Product
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 70;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 250;
        }

        public static class Category
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 25;
        }

        public static class Brand
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }
    }
}
