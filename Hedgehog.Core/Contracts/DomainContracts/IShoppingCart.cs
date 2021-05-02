using Hedgehog.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.DomainContracts
{
    public interface IShoppingCart
    {
        List<ShoppingCartItem> Items { get; set; }
        int StoreId { get; set; }

        void AddToCart(int ProductId, int amount = 1);
        Task<double> CalculateTotal();
        void ClearCart();
        void RemoveFromCart(int ProductId, int amount = 1);
    }
}