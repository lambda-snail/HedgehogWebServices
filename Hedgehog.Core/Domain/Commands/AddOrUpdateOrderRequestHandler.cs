using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    /// <summary>
    /// Adds a new Order to the system or updates an existing. The new or updated order is returned after execution.
    /// </summary>
    public class AddOrUpdateOrderRequestHandler : IRequestHandler<AddOrUpdateOrderRequest>
    {
        private readonly IMediator _mediator;
        private readonly IAsyncGenericRepository<Order, int> _orderRepository;

        public AddOrUpdateOrderRequestHandler(IMediator mediator, IAsyncGenericRepository<Order, int> orderRepository)
        {
            _mediator = mediator;
            _orderRepository = orderRepository;
        }

        public async Task<Unit> Handle(AddOrUpdateOrderRequest request, CancellationToken cancellationToken)
        {
            await _orderRepository.UpdateAsync(request.Order);
            return Unit.Value;
        }
    }
}
