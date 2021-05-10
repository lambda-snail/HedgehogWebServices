#### [Hedgehog.UI](index.md 'index')
### [Hedgehog.UI.Controllers](Hedgehog_UI_Controllers.md 'Hedgehog.UI.Controllers').[ShoppingCartController](Hedgehog_UI_Controllers_ShoppingCartController.md 'Hedgehog.UI.Controllers.ShoppingCartController')
## ShoppingCartController.CheckoutPaymentConfirmation(string, bool, int) Method
This is the last screen in the checkout process. If the payment was completed this is the  
action that gets called. If the payment failed then CheckoutPaymentOnFail will handle the recovery.  
```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CheckoutPaymentConfirmation(string storeNavigationTitle, bool paymentComplete, int orderId);
```
#### Parameters
<a name='Hedgehog_UI_Controllers_ShoppingCartController_CheckoutPaymentConfirmation(string_bool_int)_storeNavigationTitle'></a>
`storeNavigationTitle` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Hedgehog_UI_Controllers_ShoppingCartController_CheckoutPaymentConfirmation(string_bool_int)_paymentComplete'></a>
`paymentComplete` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
<a name='Hedgehog_UI_Controllers_ShoppingCartController_CheckoutPaymentConfirmation(string_bool_int)_orderId'></a>
`orderId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Microsoft.AspNetCore.Mvc.IActionResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.IActionResult 'Microsoft.AspNetCore.Mvc.IActionResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
