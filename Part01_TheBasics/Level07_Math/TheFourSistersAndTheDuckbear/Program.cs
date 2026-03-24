// Write a program that takes a number of eggs as input and equally divide that number among the four sisters from the book.
// Display the remaining number of eggs that their duckbear pet should receive.
// Disclaimer: For simplicity, this code has no checks.

Console.Write("How many eggs were laid today? " );
int numberOfEggsLaid = Convert.ToInt32(Console.ReadLine());

int eggsPerSister = numberOfEggsLaid / 4;
int eggsForDuckbear = numberOfEggsLaid % 4;

Console.WriteLine($"Number of Eggs entered: {numberOfEggsLaid}");
Console.WriteLine($"Each sister is entitled to {eggsPerSister} egg(s) today.");
Console.WriteLine($"Their Duckbear will receive {eggsForDuckbear} egg(s) this time.");