class Renderer
{
    /// <summary>
    /// Displays Player's current location with a <see cref="Point"/> object.
    /// </summary>
    /// <param name="player"><see cref="Player"/> to display location of.</param>
    public static void DisplayPlayer(Player player)
    {
        Console.Write($"You are in the room at {player.GetPositionLabel()} ");
        Console.WriteLine($"You have {player.ArrowCount} arrows left.");
    }
    /// <summary>
    /// Displays a help menu of available commands to the user.
    /// </summary>
    public static void DisplayHelper()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        
        Console.WriteLine($"You may use the following commands to move or interact with the world:");
        Console.WriteLine($"{"move north",-20} - moves you -1 Row units.");
        Console.WriteLine($"{"move south",-20} - moves you +1 Row units.");
        Console.WriteLine($"{"move east",-20} - moves you +1 Column units.");
        Console.WriteLine($"{"move west",-20} - moves you -1 Column units");
        Console.WriteLine();
        Console.WriteLine($"{"shoot north",-20} - shoots 1 arrow north");
        Console.WriteLine($"{"shoot south",-20} - shoots 1 arrow south");
        Console.WriteLine($"{"shoot east",-20} - shoots 1 arrow east");
        Console.WriteLine($"{"shoot west",-20} - shoots 1 arrow west");
        Console.WriteLine();
        Console.WriteLine($"{"enable fountain",-20} - enables The Fountain of Objects if present");
        Console.WriteLine($"{"exit cavern",-20} - allows you to exit the cavern if objective is met");
        Console.WriteLine($"{"help",-20} - opens this helper menu.");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        Console.ResetColor();
    }
    /// <summary>
    /// Prints text to console accordint to the provided foreground <see cref="ConsoleColor"/>
    /// </summary>
    /// <param name="text">Text to display.</param>
    /// <param name="color"><see cref="ConsoleColor" to display text in./></param>
    public static void PrettyPrint(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}