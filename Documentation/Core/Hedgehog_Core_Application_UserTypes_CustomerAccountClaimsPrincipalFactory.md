#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Application.UserTypes](Hedgehog_Core_Application_UserTypes.md 'Hedgehog.Core.Application.UserTypes')
## CustomerAccountClaimsPrincipalFactory Class
Adds application specific claims to the Customer class. The following claim is added:  
"WebStoreNavigationTitle" - the navigation string of the associated web store.  
```csharp
public class CustomerAccountClaimsPrincipalFactory : Microsoft.AspNetCore.Identity.UserClaimsPrincipalFactory<Hedgehog.Core.Application.CustomerAccount>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.AspNetCore.Identity.UserClaimsPrincipalFactory&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Identity.UserClaimsPrincipalFactory-1 'Microsoft.AspNetCore.Identity.UserClaimsPrincipalFactory`1')[Hedgehog.Core.Application.CustomerAccount](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Application.CustomerAccount 'Hedgehog.Core.Application.CustomerAccount')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Identity.UserClaimsPrincipalFactory-1 'Microsoft.AspNetCore.Identity.UserClaimsPrincipalFactory`1') &#129106; CustomerAccountClaimsPrincipalFactory  
