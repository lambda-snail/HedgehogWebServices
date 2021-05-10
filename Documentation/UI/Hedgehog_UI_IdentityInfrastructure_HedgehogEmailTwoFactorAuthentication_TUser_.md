#### [Hedgehog.UI](index.md 'index')
### [Hedgehog.UI.IdentityInfrastructure](Hedgehog_UI_IdentityInfrastructure.md 'Hedgehog.UI.IdentityInfrastructure')
## HedgehogEmailTwoFactorAuthentication&lt;TUser&gt; Class
Generates two-factor authentication tokens. The tokens are functions of the userid, the email and also  
the purpose of the token.  
```csharp
public class HedgehogEmailTwoFactorAuthentication<TUser> :
Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider<TUser>
    where TUser : Hedgehog.Core.Application.HedgehogUserAccount
```
#### Type parameters
<a name='Hedgehog_UI_IdentityInfrastructure_HedgehogEmailTwoFactorAuthentication_TUser__TUser'></a>
`TUser`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HedgehogEmailTwoFactorAuthentication&lt;TUser&gt;  

Implements [Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider-1 'Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider`1')[TUser](Hedgehog_UI_IdentityInfrastructure_HedgehogEmailTwoFactorAuthentication_TUser_.md#Hedgehog_UI_IdentityInfrastructure_HedgehogEmailTwoFactorAuthentication_TUser__TUser 'Hedgehog.UI.IdentityInfrastructure.HedgehogEmailTwoFactorAuthentication&lt;TUser&gt;.TUser')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider-1 'Microsoft.AspNetCore.Identity.IUserTwoFactorTokenProvider`1')  
