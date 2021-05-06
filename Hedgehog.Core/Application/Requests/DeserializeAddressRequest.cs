using Hedgehog.Core.Domain;
using MediatR;

namespace Hedgehog.Core.Application.Requests
{
    public class DeserializeAddressRequest : IRequest<Address>
    {
        public string Json { get; set; }
    }
}
