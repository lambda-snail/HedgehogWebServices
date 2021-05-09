using Hedgehog.Core.Application;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    /// <summary>
    /// This command handler takes care of everything that is needed to create an order based on a shopping cart
    /// and is the prefferred way to do so.
    /// 
    /// Any order items with an amount of 0 will be ignored.
    /// </summary>
    public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, Order>
    {
        private readonly IMediator _mediator;

        public CreateOrderRequestHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<Order> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            GuardClause.Ensure.NotNull(request.Address, "You must specify an address for the order");
            GuardClause.Ensure.NotNull(request.Customer, "You must specify a buyer for the order");
            GuardClause.Ensure
                       .NotNull(request.Cart, "You must specify a cart for the order")
                       .NotZero(request.Cart.Items.Count(), "An empty cart cannot be used as base for an order");

            Order order = new();

            order.ShippingAddress = request.Address;
            order.Customer = request.Customer;
            order.CreatedTime = DateTime.Now;

            order.OrderItems = new List<OrderItem>();
            
            foreach(var item in request.Cart.Items)
            {
                if (item.Amount > 0)
                {
                    Product product = await _mediator.Send(new GetSingleProductFromStoreRequest { StoreId = request.Customer.WebStore.WebStoreId, ProductId = item.ProductId });
                    OrderItem orderItem = new();
                    orderItem.Amount = item.Amount;
                    orderItem.ProductName = product.ProductName;
                    orderItem.ProductPrice = product.Price;
                    orderItem.ProductShortDescription = product.ShortDescription;

                    order.OrderItems.Add(orderItem);
                }
            }

            if(request.SaveToDatabase)
            {
                await _mediator.Send(new AddOrUpdateOrderRequest{ Order=order });
            }

            return order;
        }
    }
}
