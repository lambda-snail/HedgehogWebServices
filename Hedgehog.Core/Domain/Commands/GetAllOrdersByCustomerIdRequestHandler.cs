using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    /// <summary>
    /// Retreives all orders in the DB for a given customer.
    /// </summary>
    public class GetAllOrdersByCustomerIdRequestHandler : IRequestHandler<GetAllOrdersByCustomerIdRequest, IEnumerable<Order>>
    {
        private readonly IOrderRepository _orderRepository;

        public GetAllOrdersByCustomerIdRequestHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<IEnumerable<Order>> Handle(GetAllOrdersByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            return _orderRepository.GetOrdersByCustomerIdAsync(request.CustomerId);
        }
    }
}
