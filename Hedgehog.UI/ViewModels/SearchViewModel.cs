using Hedgehog.Core.Domain;
using System.Collections.Generic;

namespace Hedgehog.UI.ViewModels
{
    public class SearchViewModel
    {
        public string SearchString { get; set; }
        public IEnumerable<Product> SearchResults { get; set; }
    }
}
