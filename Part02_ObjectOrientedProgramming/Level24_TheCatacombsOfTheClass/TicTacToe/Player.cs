/// <summary>
/// Represents a player in the game of Tic-Tac-Toe.
/// Stores avatar data and validates input from user.
/// </summary>

class Player
{
    public char Avatar { get; }
    public Player(char avatar) => Avatar = avatar;

    /// <summary>
    /// Get ConsoleKey value from the user (1-9) and 'h'.
    /// </summary>
    /// <param name="text">Message to display to user.</param>
    /// <returns><c>ConsoleKey</c> if the user provided key is a predetermined value (1-9, 'h').</returns>
    public ConsoleKey GetKey(string text)
    {
        Console.Write(text);
        ConsoleKey key = Console.ReadKey().Key; 

        while(!IsValidKey(key))
        {
            Console.WriteLine();
            Console.Write("Invalid selection. Try again: ");
            key = Console.ReadKey().Key;
        }
        return key;
    }

    private bool IsValidKey(ConsoleKey key)
    {
        return key switch
        {
            ConsoleKey.NumPad7 or ConsoleKey.D7 => true,
            ConsoleKey.NumPad8 or ConsoleKey.D8 => true,
            ConsoleKey.NumPad9 or ConsoleKey.D9 => true,
            ConsoleKey.NumPad4 or ConsoleKey.D4 => true,
            ConsoleKey.NumPad5 or ConsoleKey.D5 => true,
            ConsoleKey.NumPad6 or ConsoleKey.D6 => true,
            ConsoleKey.NumPad1 or ConsoleKey.D1 => true,
            ConsoleKey.NumPad2 or ConsoleKey.D2 => true,
            ConsoleKey.NumPad3 or ConsoleKey.D3 => true,
            ConsoleKey.H => true,
            _ => false
        };
    }
}