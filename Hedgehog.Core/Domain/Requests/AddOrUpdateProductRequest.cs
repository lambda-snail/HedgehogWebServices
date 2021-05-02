using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class AddOrUpdateProductRequest : IRequest
    {
        public Product Product { get; set; }
    }
}
