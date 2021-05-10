#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Application](Hedgehog_Core_Application.md 'Hedgehog.Core.Application')
## GuardClause Class
Provides a fluent API for checking certain conditions on objects, such as if the reference is null.  
  
Usage:  
  GuardClause.Check.EnsureNotNull(myObject, "ErrorMsg")  
  GuardClause.Check.EnsureNotNull(myObject, "ErrorMsg").EnsureNotZero(myObject.IntProperty);  
  
```csharp
public class GuardClause
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GuardClause  
### Methods

***
[NotNull(object, string)](Hedgehog_Core_Application_GuardClause_NotNull(object_string).md 'Hedgehog.Core.Application.GuardClause.NotNull(object, string)')

Ensures that the specified object is not null. If the object is null an ArgumentNullException  
will be thrown with the specified message.  

***
[NotZero(int, string)](Hedgehog_Core_Application_GuardClause_NotZero(int_string).md 'Hedgehog.Core.Application.GuardClause.NotZero(int, string)')

Ensures that the specified object is not 0. If the object is null an ArgumentNullException  
will be thrown with the specified message.  
