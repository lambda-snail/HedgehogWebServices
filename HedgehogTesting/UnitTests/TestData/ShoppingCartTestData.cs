using Hedgehog.Core.Domain;
using MediatR;
using Moq;
using System.Collections.Generic;

namespace HedgehogTesting.UnitTests.TestData
{
    class ShoppingCartTestData
    {
        /// <summary>
        /// Creates a Shopping cart with a mock mediator and that has products with the given product ids.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="mediator"></param>
        /// <returns></returns>
        public static ShoppingCart Get(int storeId, List<int> productIds, Mock<IMediator> mediator=null)
        {
            //public int StoreId { get; set; }
            // public List<ShoppingCartItem> Items { get; set; }

            mediator ??= new Mock<IMediator>();
            ShoppingCart cart = new ShoppingCart(mediator.Object) { StoreId = storeId, Items=new List<ShoppingCartItem>() };

            int i = 1;
            foreach(int id in productIds)
            {
                cart.Items.Add( new ShoppingCartItem { ProductId=id, Amount=i++ } );
            }

            return cart;
        }
    }
}
