// Write a program that determines whether an input number is even or odd.
// Display 'Tick' for even and 'Tock' for odd numbers.
// Disclaimer: For simplicity this code has no checks.

Console.Write("Please enter a number: ");
int clockNumber = Convert.ToInt32(Console.ReadLine());

if (clockNumber % 2 == 0 )
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

