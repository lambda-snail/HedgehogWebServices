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

        /// <summary>
        /// Used when navigating to a store. Must consist of only alphanumerics and no spaces.
        /// </summary>
        public string NavigationTitle { get; set; }

        public string HedgehogUserAccountForeignKey { get; set; }
        public HedgehogUserAccount Owner { get; set; }

        //public Dictionary<Guid, CustomerAccount> Customers { get; set; }
    }
}
