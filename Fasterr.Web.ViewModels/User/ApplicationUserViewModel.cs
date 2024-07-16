using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Fasterr.Common.EntityValidationConstants.ApplicationUser;

namespace Fasterr.Web.ViewModels.User
{
    public class ApplicationUserViewModel
    {
        [Required]
        public string Id { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string ImageURL { get; set; } = string.Empty;
    }
}
