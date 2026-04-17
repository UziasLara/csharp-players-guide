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
        Console.WriteLine();
        Console.WriteLine($"{"show intro",-20} - shows introductory game text");
        Console.WriteLine($"{"help",-20} - opens this helper menu.");
        Console.WriteLine();

        Console.ResetColor();

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    /// <summary>
    /// Prints text to console according to the provided foreground <see cref="ConsoleColor"/>
    /// </summary>
    /// <param name="text">Text to display.</param>
    /// <param name="color"><see cref="ConsoleColor" to display text in./></param>
    public static void PrettyPrint(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    /// <summary>
    /// Displays introductory game text.
    /// </summary>    
    public static void DisplayIntroduction()
    {
        Console.Clear();
        string introText = """
        You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search of the Fountain of Objects. 
        Light is visible only in the entrance, and no other light is seen anywhere in the caverns. 
        You must navigate the Caverns with your other senses. 
        Find the Fountain of Objects, activate it, and return to the entrance
        Look out for pits. You will feel a breeze if a pit is in an adjacent room. If you enter a room with a pit, you will die.
        Maelstroms are violent forces of sentient wind. Entering a room with one could transport you to any other location in the caverns. 
        You will be able to hear their growling and groaning in nearby rooms.
        Amaroks roam the caverns. Encountering one is certain death, but you can smell their rotten stench in nearby rooms.
        You carry with you a bow and a quiver of arrows. You can use them to shoot monsters in the caverns but be warned: you have a limited supply.
        """;

        PrettyPrint(introText, ConsoleColor.Blue);
        Console.WriteLine();
        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();
    }
}