#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Application](Hedgehog_Core_Application.md 'Hedgehog.Core.Application').[GuardClause](Hedgehog_Core_Application_GuardClause.md 'Hedgehog.Core.Application.GuardClause')
## GuardClause.NotZero(int, string) Method
Ensures that the specified object is not 0. If the object is null an ArgumentNullException  
will be thrown with the specified message.  
```csharp
public Hedgehog.Core.Application.GuardClause NotZero(int i, string errorMessage="");
```
#### Parameters
<a name='Hedgehog_Core_Application_GuardClause_NotZero(int_string)_i'></a>
`i` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='Hedgehog_Core_Application_GuardClause_NotZero(int_string)_errorMessage'></a>
`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[GuardClause](Hedgehog_Core_Application_GuardClause.md 'Hedgehog.Core.Application.GuardClause')  
