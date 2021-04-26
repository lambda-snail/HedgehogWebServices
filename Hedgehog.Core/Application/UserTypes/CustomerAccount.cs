using Hedgehog.Core.Domain;

namespace Hedgehog.Core.Application
{
    /// <summary>
    /// Represents the account of a user of a web store.
    /// </summary>
    public class CustomerAccount : HedgehogUserBase
    {
        /// <summary>
        /// The Id of the WebStore this user is regestered to.
        /// </summary>
        public int WebStoreId { get; set; }
        /// <summary>
        /// A navigation property to the associated WebStore.
        /// </summary>
        public WebStore WebStore { get; set; }
    }
}
