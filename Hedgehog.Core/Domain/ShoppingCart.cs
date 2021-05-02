using Hedgehog.Core.Contracts.DomainContracts;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain
{
    /// <summary>
    /// A simple shopping cart that is designed to be small and thus should be relatively cheap to instantiate
    /// as needed during the handling of a request.
    /// </summary>
    public class ShoppingCart : IShoppingCart
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// The Id of the store is saved to prevent shopping carts accidentally being transferred between
        /// sessions of different customers.
        /// </summary>
        public int StoreId { get; set; }
        public List<ShoppingCartItem> Items { get; set; }

        public ShoppingCart(IMediator mediator)
        {
            _mediator = mediator;
            Items = new();
        }

        /// <summary>
        /// Calculates the total cost of all items in the shopping cart. This call will connect
        /// to the database.
        /// </summary>
        public async Task<double> CalculateTotal()
        {
            double total = 0d;
            foreach (var item in Items)
            {
                Product product = await _mediator.Send(new GetSingleProductFromStoreRequest { ProductId = item.ProductId, StoreId = StoreId });
                total += product.Price * item.Amount;
            }

            return total;
        }

        /// <summary>
        /// Add an amount of the given product. If a product with the given id does not exist in the cart, it will be
        /// added with the specified amount.
        /// </summary>
        /// <exception cref="ArgumentException">If amount is less than or equal to 0.</exception>
        /// <param name="amount">Defaults to 1.</param>
        public void AddToCart(int ProductId, int amount = 1)
        {
            if (amount <= 0) throw new ArgumentException("You must choose a positive amount to add");

            var item = Items.FirstOrDefault(item => item.ProductId == ProductId);

            if (item == null)
            {
                Items.Add(new ShoppingCartItem { ProductId = ProductId, Amount = amount });
            }
            else
            {
                item.Amount += amount;
            }
        }

        /// <summary>
        /// Removes a given quantity of the specified product from the shopping cart. If a product with the given id 
        /// does not exist in the cart, the method will exit silently.
        /// </summary>
        /// <exception cref="ArgumentException">If amount is less than or equal to 0.</exception>
        /// <param name="amount">Defaults to 1.</param>
        public void RemoveFromCart(int ProductId, int amount = 1)
        {
            if (amount <= 0) throw new ArgumentException("You must choose a positive amount to add");

            var item = Items.FirstOrDefault(item => item.ProductId == ProductId);

            if (item != null)
            {
                int newAmount = (item.Amount -= amount);
                if (newAmount <= 0)
                {
                    Items.Remove(item);
                }
                else
                {
                    item.Amount = newAmount;
                }
            }
        }

        public async Task<Product> GetProduct(ShoppingCartItem item)
        {
            return await _mediator.Send(new GetSingleProductFromStoreRequest { ProductId = item.ProductId });
        }

        public void ClearCart()
        {
            Items = new List<ShoppingCartItem>();
        }
    }
}
