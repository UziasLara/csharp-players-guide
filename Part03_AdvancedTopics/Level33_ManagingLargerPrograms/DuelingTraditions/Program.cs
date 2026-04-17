// Using a previous program as a reference, write a traditional Program and Main method as the entry point of your program.
// Place every type in its own file.
// Crete two namespaces IField and McDroid with classes Sheep, Pig, and Cow, Pig respectively. 
// Make new instances of all 4 classes, resolving any name conflicts that may arise.
using Farm;
class Program
{
    public static void Main(string[] args)
    {
        Sheep sheep = new Sheep();
        Pig pig = new Pig();
        Cow cow = new Cow();        

        Console.WriteLine($"The fully qualified name of {sheep.GetType().Name} is: {sheep.GetType()}");
        Console.WriteLine($"The fully qualified name of {pig.GetType().Name} is: {pig.GetType()}");
        Console.WriteLine($"The fully qualified name of {cow.GetType().Name} is: {cow.GetType()}");
        Console.WriteLine(); 
    }
}



