using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using Hedgehog.Core.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.Commands
{
    public class SerializeAddressRequestHandler : IRequestHandler<SerializeAddressRequest, string>
    {
        private readonly ISerializer<Address> _serializer;

        public SerializeAddressRequestHandler(ISerializer<Address> serializer)
        {
            _serializer = serializer;
        }

        public async Task<string> Handle(SerializeAddressRequest request, CancellationToken cancellationToken)
        {
            return await _serializer.SerializeAsync(request.Address);
        }
    }
}
