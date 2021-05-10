#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain').[ShoppingCart](Hedgehog_Core_Domain_ShoppingCart.md 'Hedgehog.Core.Domain.ShoppingCart')
## ShoppingCart.AddToCart(int, int) Method
Add an amount of the given product. If a product with the given id does not exist in the cart, it will be  
added with the specified amount.  
```csharp
public void AddToCart(int ProductId, int amount=1);
```
#### Parameters
<a name='Hedgehog_Core_Domain_ShoppingCart_AddToCart(int_int)_ProductId'></a>
`ProductId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='Hedgehog_Core_Domain_ShoppingCart_AddToCart(int_int)_amount'></a>
`amount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Defaults to 1.
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If amount is less than or equal to 0.

Implements [AddToCart(int, int)](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.AddToCart#Hedgehog_Core_Contracts_DomainContracts_IShoppingCart_AddToCart_System_Int32,System_Int32_ 'Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.AddToCart(System.Int32,System.Int32)')  
