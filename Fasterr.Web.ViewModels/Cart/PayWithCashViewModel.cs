using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Fasterr.Common.EntityValidationConstants.PayWithCardOrCash;
using static Fasterr.Common.ErrorMessages;

namespace Fasterr.Web.ViewModels.Cart
{
    public class PayWithCashViewModel
    {
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength, ErrorMessage = LengthMessage)]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = LengthMessage)]
        public string Address { get; set; } = null!;

        public decimal? TotalAmount { get; set; }
    }
}
