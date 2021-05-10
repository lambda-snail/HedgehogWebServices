#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Application](Hedgehog_Core_Application.md 'Hedgehog.Core.Application').[GuardClause](Hedgehog_Core_Application_GuardClause.md 'Hedgehog.Core.Application.GuardClause')
## GuardClause.NotNull(object, string) Method
Ensures that the specified object is not null. If the object is null an ArgumentNullException  
will be thrown with the specified message.  
```csharp
public Hedgehog.Core.Application.GuardClause NotNull(object o, string errorMessage="");
```
#### Parameters
<a name='Hedgehog_Core_Application_GuardClause_NotNull(object_string)_o'></a>
`o` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Hedgehog_Core_Application_GuardClause_NotNull(object_string)_errorMessage'></a>
`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[GuardClause](Hedgehog_Core_Application_GuardClause.md 'Hedgehog.Core.Application.GuardClause')  
