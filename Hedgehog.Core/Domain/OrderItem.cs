using System;

namespace Hedgehog.Core.Domain
{
    /// <summary>
    /// Represents a product that is part of an order. There is no reference to a Product object
    /// here, instead the OrderItem will store some properties of the Product from which it derives.
    /// This is so that changes in a Product in the Db will not have strange effects on already completed
    /// orders.
    /// </summary>
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        //public int Amount { get; set; }

        private int _amount;
        public int Amount
        {
            get => _amount;
            set
            {
                if (value <= 0) { throw new ArgumentException("The amount must not be negative or 0."); }
                else { _amount = value; }
            }
        }

        public string ProductName { get; set; }
        public string ProductShortDescription { get; set; }
        public double ProductPrice { get; set; }
    }
}
