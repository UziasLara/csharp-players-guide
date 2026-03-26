## Knowledge Check: Memory

1. **Anything can be accessed from the stack at any time.**
    
    > **False**. The stack works on the last in, first out principle.

2. **Local variables are tracked by the stack.**
    
    > **True**. The stack tracks the existance of local variables but their location depends on their type.

3. **Value types values can be placed in the heap.**

    > **True**. Value types can be placed on the heap when they live within a reference type.

4. **Value types are *always* placed in the heap.**

    > **False**. Value types are primarily placed on the stack and ocasionally on the heap if held by a reference type.

5. **Reference types are *always* placed in the heap.**

    > **True**. The contents of a reference types are always placed in the heap.

6. **The garbage collector cleans up old, unused space on the heap and stack.**

    > **False**. The garbage collector periodically cleans up unused references on the heap but not the stack.

7. **If two arrays, a, and b, reference the same object, modifying a will modify b.**

    > **True**. Since both a and b point to the same reference, any changes made to either variable, will affect the reference they point to.

8. **If a, and b are ints with the same value, changing one will affect the other.**

    > **False**. Changes to one value type will not affect other value types even if their values are the same.