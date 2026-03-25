// Write a program that takes a user coordinate, i.e. (6,5) and computes the surrounding North, South, East, and West coordinates.
// Change the title of the console to 'Defense of Consolas'
// Change the color of the new coordinates in the console. 
// Once results are computed, make the console beep.
// Disclaimer: For simplicity, this code has no checks.

Console.Title = "Defense Of Consolas";

Console.Write("Target Row? ");
int targetRow = Convert.ToInt16(Console.ReadLine());
Console.Write("Target Column? ");
int targetCol = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Deploy to:");
Console.WriteLine($"Northern Front: ({targetRow+1}, {targetCol})");
Console.WriteLine($"Southern Front: ({targetRow-1}, {targetCol})");
Console.WriteLine($"Eastern Front: ({targetRow}, {targetCol-1})");
Console.WriteLine($"Western Front: ({targetRow}, {targetCol+1})");

Console.Beep();