using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.Commands
{
    public class DeserializeFromJsonRequestHandler<T> : IRequestHandler<DeserializeFromJsonRequest<T>, T>
    {
        private readonly ISerializer<T> _serializer;

        public DeserializeFromJsonRequestHandler(ISerializer<T> serializer)
        {
            _serializer = serializer;
        }

        public async Task<T> Handle(DeserializeFromJsonRequest<T> request, CancellationToken cancellationToken)
        {
            return await _serializer.DeserializeAsync(request.Json);
        }
    }
}
