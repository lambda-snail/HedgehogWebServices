#### [Hedgehog.UI](index.md 'index')
### [Hedgehog.UI.Controllers](Hedgehog_UI_Controllers.md 'Hedgehog.UI.Controllers').[ShoppingCartController](Hedgehog_UI_Controllers_ShoppingCartController.md 'Hedgehog.UI.Controllers.ShoppingCartController')
## ShoppingCartController.AddToCart(string, int) Method
Add an item to the cart. The code also check so that the item is not in a different store  
than the cart. If so the customer will be presented with a message and offered to clear the cart.  
```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> AddToCart(string storeNavigationTitle, int productId);
```
#### Parameters
<a name='Hedgehog_UI_Controllers_ShoppingCartController_AddToCart(string_int)_storeNavigationTitle'></a>
`storeNavigationTitle` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Hedgehog_UI_Controllers_ShoppingCartController_AddToCart(string_int)_productId'></a>
`productId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Microsoft.AspNetCore.Mvc.IActionResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.IActionResult 'Microsoft.AspNetCore.Mvc.IActionResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
