using Hedgehog.Core.Application;
using System;
using System.Collections.Generic;

namespace Hedgehog.Core.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? FinalizedTime { get; set; } = null;

        public List<OrderItem> OrderItems { get; set; }
        public Address ShippingAddress { get; set; }

        public CustomerAccount Customer { get; set; }

        /// <summary>
        /// Returns true if and only if the transaction associated with this order is completed.
        /// </summary>
        /// <returns></returns>
        public bool IsCompletedTransaction()
        {
            return FinalizedTime == null;
        }
    }
}
