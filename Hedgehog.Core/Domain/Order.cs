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
            return FinalizedTime != null;
        }

        /// <summary>
        /// Returns the total of the order. This does not require a trip to the database.
        /// </summary>
        public double GetOrderTotal()
        {
            double total = 0d;
            foreach(var item in OrderItems)
            {
                total += item.Amount * item.ProductPrice;
            }
            return total;
        }

        /// <summary>
        /// Marks the order as complete.
        /// </summary>
        public void FinalizeOrder()
        {
            FinalizedTime = DateTime.Now;
        }
    }
}
