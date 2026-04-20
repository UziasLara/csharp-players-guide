## The Sieve

**How could you have solved this challenge with inheritance and polymorphism? Which is more straightforward and why?**

>I could have created a base Sieve class, placed each method within a distinct derived Sieve class. Delegates are more dynamic as the methods can be written anywhere and not be tied to a specific class. It's only straighforward if you understand delegates. Classes are just fine, specially if more operations need to be performed on each derived class.