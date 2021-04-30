namespace Hedgehog.Core.Domain
{
    /// <summary>
    /// An item in a shopping cart consisting of a product id and an amount. The class is designed to
    /// be lightweight to allow for efficient serialization and deserialization, as well as storage in
    /// the browser session.
    /// 
    /// As only product id is stored, the product object must be retreived from the database before processing.
    /// </summary>
    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}
