## Knowledge Check: Methods

>**Use the following for questions 1-3:**
>```csharp
>void DoSomething(int x, int y =3, int z =4) { ... }

1. **Which parameters are optional?**

    >`int y`, and `int z` are optional

2. **What are the values of each parameter when `DoSomething(1,2);` is called?**

    >For x, y, and z the values are **1**, **2**, and **4** respectively.

3. **What about when `DoSomething(x: 2, z: 9);` is called?**

    >For x, y, and z the values are **2**, **3**, and **9** respectively.

4. **Required parameters must be defined before optional parameters.**

    >**True**. Optional parameters may be added after all required parameters have been defined.

5. **The `params` keywoard may only be used with the last parameter.**

    >**True**. It may only appear next to the last parameter in a method's signature.

6. **With which keyword is a method able to become an extension method by adding it as part of its parameters?**

    >By adding the `this` keyword to the method's signature, it can be used as an extension method.

7. **What keywords denotes a parameter is passed by reference?**

    >The `ref` keyword indicates when the parameter is passed by reference.

8.  **Given the following method 
    which of the these are allowed?**
    
    **a)**`DoSomething();`
    
    **b)**`DoSomething(1);`
    
    **c)**`DoSomething(1, 2, 3, 4, 5);`
    
    **d)**`DoSomething(1, new int[] {2, 3, 4, 5});`
    ```chsarp
    void DoSomething(int x, params int[] numbers) { ... }
    ```    
    > **b**, **c**, and **d** are allowed.
    
