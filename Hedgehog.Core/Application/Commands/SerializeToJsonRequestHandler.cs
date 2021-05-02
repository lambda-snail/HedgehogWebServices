using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.Commands
{
    public class SerializeToJsonRequestHandler<T> : IRequestHandler<SerializeToJsonRequest<T>, string>
    {
        private readonly ISerializer<T> _serializer;

        public SerializeToJsonRequestHandler(ISerializer<T> serializer)
        {
            _serializer = serializer;
        }
        public async Task<string> Handle(SerializeToJsonRequest<T> request, CancellationToken cancellationToken)
        {
            return await _serializer.SerializeAsync(request.Entity);
        }
    }
}
