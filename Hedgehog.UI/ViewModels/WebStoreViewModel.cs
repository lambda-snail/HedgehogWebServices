
using System.ComponentModel.DataAnnotations;

namespace Hedgehog.UI.ViewModels
{
    public class WebStoreViewModel
    {
        [Display(Name = "Store Title")]
        [Required(ErrorMessage = "Please enter a title for your store.")]
        [StringLength(256)]
        public string StoreTitle { get; set; }

        [Display(Name = "Navigation String")]
        [Required(ErrorMessage = "Please enter navigation string for your store.")]
        [StringLength(64)]
        public string NavigationTitle { get; set; }

        [Display(Name = "Store Description")]
        public string StoreDescription { get; set; }
    }
}
