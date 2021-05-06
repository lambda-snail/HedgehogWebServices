using Hedgehog.Core.Domain;
using MediatR;

namespace Hedgehog.Core.Application.Requests
{
    public class SerializeAddressRequest : IRequest<string>
    {
        public Address Address { get; set; }
    }
}
