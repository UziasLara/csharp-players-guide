// Write a program that takes 5 numbers from a user and stores them in an array.
// Using loops, replicate the array values into a new array and display the contents of both arrays.
// Disclaimer: For simplicity, this code has no input checks.

int [] original = new int [5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Please provide a number: ");
    original[i] = Convert.ToInt32(Console.ReadLine());
}

int [] copy = new int[original.Length];
for (int j = 0; j < original.Length; j++)
{
    copy[j] = original[j];
}
Console.WriteLine("----------------------------");
Console.WriteLine("Results:");
for (int k = 0; k < original.Length; k++)
{
    Console.WriteLine($"Original: {original[k]} Copy: {copy[k]}");
}
