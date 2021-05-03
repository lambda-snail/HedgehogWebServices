using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.UI.ViewModels
{
    public class AddressViewModel
    {
        public int AddressId { get; set; }

        [Required(ErrorMessage = "Please enter a recipient for your products.")]
        [StringLength(256)]
        public string Recipient { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Please enter an address so that we know where to ship your things!")]
        [StringLength(256)]
        public string StreetAddress { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Please enter a zip code!")]
        [StringLength(256)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter an city.")]
        [StringLength(256)]
        public string City { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please enter the country to ship to.")]
        [StringLength(256)]
        public string Country { get; set; }
    }
}
