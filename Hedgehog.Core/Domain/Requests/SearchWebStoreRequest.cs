using MediatR;
using System.Collections.Generic;

namespace Hedgehog.Core.Domain.Requests
{
    /// <summary>
    /// Search a given web store for products with the given string in their description or title.
    /// </summary>
    public class SearchWebStoreRequest : IRequest<IEnumerable<Product>>
    {
        public int StoreId { get; set; }
        public string SearchString { get; set; }
    }
}
