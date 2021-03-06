using Hedgehog.Core.Domain;

namespace Hedgehog.UI.ViewModels
{
    /// <summary>
    /// Contains all the data needed to properly render the payment screen to the user.
    /// </summary>
    public class PaymentSummaryViewModel
    {
        public string WebStoreName { get; set; }
        public Order Order { get; set; }
    }
}
