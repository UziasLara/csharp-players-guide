// REFACTOR this program to use lambda expressions instead of named methods.
// Write a program using delegates that filters whether a give number is a "good" number according to the respective operation performed on it.
// See book for details.
// Disclaimer: For simplicity, this code has minimal checks.

Console.Write("Would you like to check if your number is \x1b[1meven\x1b[0m, \x1b[1mpositive\x1b[0m, or a \x1b[1mmultiple\x1b[0m of ten? ");
string choice = Console.ReadLine().ToLower();

Sieve sieve = choice switch
{
    "even" => new Sieve(n => n % 2 == 0),
    "positive" => new Sieve(n => n > 0),
    "multiple" => new Sieve(n => n % 10 == 0)
};

while (true)
{
    Console.Write("Please enter a number to check: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(sieve.IsGood(number));

}
