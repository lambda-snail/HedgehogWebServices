using Hedgehog.Core.Domain;
using System.Collections.Generic;

namespace Hedgehog.Core.Application
{
    public class CustomerAccount : HedgehogUserAccount
    {
        //public int WebStoreId { get; set; }
        public WebStore WebStore { get; set; }

        public List<Order> Orders { get; set; }
    }
}
