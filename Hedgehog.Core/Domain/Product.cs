
namespace Hedgehog.Core.Domain
{
    /// <summary>
    /// Represents a product in a web store.
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        // Navigation properties
        public WebStore WebStore { get; set; }
        public int WebStoreId { get; set; }
    }
}
