using Hedgehog.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.UI.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int StoreId { get; set; }
        public List<ShoppingCartItem> Items { get; set; }
    }
}
