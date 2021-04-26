using Hedgehog.Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain
{
    /// <summary>
    /// Represents the web store woned by a ServiceUser.
    /// </summary>
    public class WebStore
    {
        public int WebStoreId { get; set; }
        public string StoreTitle { get; set; }

        public string ServiceUserAccountForeignKey { get; set; }
        public ServiceUserAccount Owner { get; set; }

        //public Dictionary<Guid, CustomerAccount> Customers { get; set; }
    }
}
