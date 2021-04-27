using MediatR;
using System.Collections.Generic;

namespace Hedgehog.Core.Domain.Requests
{
    public class GetProductsFromStoreRequest : IRequest<IEnumerable<Product>>
    {
        public int StoreId { get; set; }
    }
}
