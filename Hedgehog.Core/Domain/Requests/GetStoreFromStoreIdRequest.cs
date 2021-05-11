using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class GetStoreFromStoreIdRequest : IRequest<WebStore>
    {
        public int StoreId { get; set; }
    }
}
