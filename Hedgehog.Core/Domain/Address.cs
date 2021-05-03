namespace Hedgehog.Core.Domain
{
    /// <summary>
    /// A stub implementation for a generic address for demo purposes. It is designed to look like an average address 
    /// that you would find in most countries, but without the details.
    /// </summary>
    public class Address
    {
        public int AddressId { get; set; }
        public string Receiver { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
