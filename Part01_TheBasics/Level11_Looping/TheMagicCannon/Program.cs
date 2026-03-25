// Write a program that loops from 1 to 100.
// Display the turn as red if divisible by 3, yellow if divisible by 5, and blue if divisible by both. 

for (int turn = 1; turn <= 100; turn ++)
{
    bool isFire = turn % 3 == 0;
    bool isElectric = turn % 5 == 0;

    if ( isFire && isElectric)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{turn}: Powerful blast incoming!");
    }
    else if (isFire)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{turn}: Fire");
    }
    else if (isElectric)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{turn}: Electric");
    }
    else Console.WriteLine($"{turn}: Normal");

    Console.ResetColor();
}

