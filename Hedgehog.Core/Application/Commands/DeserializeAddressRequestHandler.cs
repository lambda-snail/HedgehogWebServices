using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using Hedgehog.Core.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.Commands
{
    public class DeserializeAddressRequestHandler : IRequestHandler<DeserializeAddressRequest, Address>
    {
        private readonly ISerializer<Address> _serializer;

        public DeserializeAddressRequestHandler(ISerializer<Address> serializer)
        {
            _serializer = serializer;
        }

        public async Task<Address> Handle(DeserializeAddressRequest request, CancellationToken cancellationToken)
        {
            return await _serializer.DeserializeAsync(request.Json);
        }
    }
}
