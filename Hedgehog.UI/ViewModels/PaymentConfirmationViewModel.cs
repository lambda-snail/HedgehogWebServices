namespace Hedgehog.UI.ViewModels
{
    public class PaymentConfirmationViewModel
    {
        public int OrderId { get; set; }
        public bool PurchaseCompleted { get; set; }
        public string OnPurchaseNotCompleteMessage { get; set; } = "An unknown error occurred attempting to capture payment. Please try again.";
        public string OnPurchaseCompleteMessage { get; set; } = "Purchase completed successfully!";
    }
}
