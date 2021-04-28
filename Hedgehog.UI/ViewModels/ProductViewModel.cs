using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.UI.ViewModels
{
    public class ProductViewModel
    {
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Please enter a product name")]
        [StringLength(256)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a short description of your product")]
        [Display(Name = "Short Description")]
        [StringLength(1024)]
        public string ShortDescription { get; set; }

        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }

        [Required(ErrorMessage = "You must enter a price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter a valid url")]
        [Display(Name = "Image Url")]
        [StringLength(1024)]
        public string ImageUrl { get; set; }
    }
}
