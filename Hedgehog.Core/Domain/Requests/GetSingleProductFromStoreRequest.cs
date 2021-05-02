using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class GetSingleProductFromStoreRequest : IRequest<Product>
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
    }
}
