using Hedgehog.Core.Application;
using System.Collections.Generic;

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

        /// <summary>
        /// The owner of the web store.
        /// </summary>
        public string UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }

        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
