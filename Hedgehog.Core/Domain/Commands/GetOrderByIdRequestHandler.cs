using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    public class GetOrderByIdRequestHandler : IRequestHandler<GetOrderByIdRequest, Order>
    {
        private readonly IAsyncGenericRepository<Order, int> _orderRepository;

        public GetOrderByIdRequestHandler(IAsyncGenericRepository<Order, int> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<Order> Handle(GetOrderByIdRequest request, CancellationToken cancellationToken)
        {
            return _orderRepository.GetByIdAsync(request.OrderId);
        }
    }
}
