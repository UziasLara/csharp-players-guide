## Better Random

**Would it be better to create a derived AdvancedRandom class to add these methods or use extension methods instead?**

>I think it is better to use extension methods because you can call them directly on an instance of the, in this case Random, class.
>Otherwise, an instance of the derived class would need to be declared unless defined as static, at which point it would need to be called with its class name..