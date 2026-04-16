class Renderer
{
    /// <summary>
    /// Displays Player's current location with a <see cref="Point"/> object.
    /// </summary>
    /// <param name="player"><see cref="Player"/> to display location of.</param>
    public static void DisplayPlayer(Player player) => Console.WriteLine($"You are in the room at {player.GetPositionLabel()}");
    /// <summary>
    /// Displays a help menu of available commands to the user.
    /// </summary>
    public static void DisplayHelper()
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine($"You may use the following commands to move or interact with the world:");
        Console.WriteLine($"{"move north", -20} - moves you -1 Row units.");
        Console.WriteLine($"{"move south", -20} - moves you +1 Row units.");
        Console.WriteLine($"{"move east", -20} - moves you +1 Column units.");
        Console.WriteLine($"{"move west", -20} - moves you -1 Column units");
        Console.WriteLine($"{"enable fountain", -20} - enables The Fountain of Objects if present");
        Console.WriteLine($"{"exit cavern", -20} - allows you to exit the cavern if objective is met");
        Console.WriteLine($"{"help", -20} - opens this helper menu.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        
        Console.ResetColor();
    }
}