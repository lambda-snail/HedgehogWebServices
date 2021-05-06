using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.Commands
{
    class GetCustomerWithNavigationPropertiesRequestHandler : IRequestHandler<GetCustomerWithNavigationPropertiesRequest, CustomerAccount>
    {
        private readonly ICustomerAccountManagerExtensions _customerExtensions;

        public GetCustomerWithNavigationPropertiesRequestHandler(ICustomerAccountManagerExtensions customerExtensions)
        {
            _customerExtensions = customerExtensions;
        }

        public async Task<CustomerAccount> Handle(GetCustomerWithNavigationPropertiesRequest request, CancellationToken cancellationToken)
        {
            return await _customerExtensions.GetByIdAsyncWithNavigation(request.UserId);
        }
    }
}
