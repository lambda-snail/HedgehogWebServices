#### [Hedgehog.Core](index.md 'index')
## Hedgehog.Core.Domain Namespace
### Classes

***
[Address](Hedgehog_Core_Domain_Address.md 'Hedgehog.Core.Domain.Address')

A stub implementation for a generic address for demo purposes. It is designed to look like an average address   
that you would find in most countries, but without the details.  

***
[Order](Hedgehog_Core_Domain_Order.md 'Hedgehog.Core.Domain.Order')


***
[OrderItem](Hedgehog_Core_Domain_OrderItem.md 'Hedgehog.Core.Domain.OrderItem')

Represents a product that is part of an order. There is no reference to a Product object  
here, instead the OrderItem will store some properties of the Product from which it derives.  
This is so that changes in a Product in the Db will not have strange effects on already completed  
orders.  

***
[Product](Hedgehog_Core_Domain_Product.md 'Hedgehog.Core.Domain.Product')

Represents a product in a web store.  

***
[ShoppingCart](Hedgehog_Core_Domain_ShoppingCart.md 'Hedgehog.Core.Domain.ShoppingCart')

A simple shopping cart that is designed to be small and thus should be relatively cheap to instantiate  
as needed during the handling of a request.  

***
[ShoppingCartItem](Hedgehog_Core_Domain_ShoppingCartItem.md 'Hedgehog.Core.Domain.ShoppingCartItem')

An item in a shopping cart consisting of a product id and an amount. The class is designed to  
be lightweight to allow for efficient serialization and deserialization, as well as storage in  
the browser session.  
  
As only product id is stored, the product object must be retreived from the database before processing.  

***
[WebStore](Hedgehog_Core_Domain_WebStore.md 'Hedgehog.Core.Domain.WebStore')

Represents the web store woned by a ServiceUser.  
