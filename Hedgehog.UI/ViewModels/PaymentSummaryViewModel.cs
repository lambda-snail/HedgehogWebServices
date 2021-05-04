using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.UI.ViewModels
{
    /// <summary>
    /// Contains all the data needed to properly render the payment screen to the user.
    /// </summary>
    public class PaymentSummaryViewModel
    {
        public string WebStoreName { get; set; }
        public double TotalAmount { get; set; }
    }
}
