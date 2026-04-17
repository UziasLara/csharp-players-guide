## Knowledge Check: Large Programs

1. **You don't have to type out fully qualified names with `using` directives.**

    > **True**. ***using*** defines the working namespace such that you don't have to type System.Text.StringBuilder every time you want to use StringBuilder or similar.

2. **How would you use the namespaces of `Console`, `List`, and `StringBuilder`?**
    >The namespaces are:
    >```csharp
    >using System;                      // Console
    >using System.Collections.Generic;  // List
    >using System.Text;                 // StringBuilder

3. **How do you declare a namespace?**

    >Namespaces can be created by using the `namespace` keyword:
    >```csharp
    >namespace MyNamespace{ /*...*/ }
    >namespace MyNamespace;

4. **You should never write your own Program class and Method.**

    > **False**. You can write your own entry point.