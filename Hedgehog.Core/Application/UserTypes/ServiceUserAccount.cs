using Hedgehog.Core.Domain;

namespace Hedgehog.Core.Application
{
    /// <summary>
    /// Represents the account of a service user, i.e. a user who owns a web store.
    /// </summary>
    public class ServiceUserAccount : HedgehogUserBase
    {
        public WebStore WebStore { get; set; }
        public string CompanyName { get; set; }

    }
}
