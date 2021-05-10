#### [Hedgehog.UI](index.md 'index')
### [Hedgehog.UI.Controllers](Hedgehog_UI_Controllers.md 'Hedgehog.UI.Controllers')
## ShoppingCartController Class
```csharp
public class ShoppingCartController : Microsoft.AspNetCore.Mvc.Controller
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.AspNetCore.Mvc.ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase') &#129106; [Microsoft.AspNetCore.Mvc.Controller](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Mvc.Controller 'Microsoft.AspNetCore.Mvc.Controller') &#129106; ShoppingCartController  
### Methods

***
[CheckoutPaymentConfirmation(string, bool, int)](Hedgehog_UI_Controllers_ShoppingCartController_CheckoutPaymentConfirmation(string_bool_int).md 'Hedgehog.UI.Controllers.ShoppingCartController.CheckoutPaymentConfirmation(string, bool, int)')

This is the last screen in the checkout process. If the payment was completed this is the  
action that gets called. If the payment failed then CheckoutPaymentOnFail will handle the recovery.  

***
[ClearShoppingCart()](Hedgehog_UI_Controllers_ShoppingCartController_ClearShoppingCart().md 'Hedgehog.UI.Controllers.ShoppingCartController.ClearShoppingCart()')

Clears the shopping cart, i.e. after a completed purchase.  
