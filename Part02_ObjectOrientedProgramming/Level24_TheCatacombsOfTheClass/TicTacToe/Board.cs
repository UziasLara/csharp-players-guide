/// <summary>
/// Manages the current board for the Tic-Tac-Toe game.
/// </summary>
class GameBoard
{
    // Initialize a 2D char-array to empty ' ' values. 
    public char[,] Board { get; private set; } =
    {
      {' ', ' ', ' '},
      {' ', ' ', ' '},
      {' ', ' ', ' '}
    };

    /// <summary>
    /// Determine whether the board slot corresponding to a key press is available.
    /// </summary>
    /// <param name="key">The key pressed by the user using top-row or numpad keys from 1-9</param>
    /// <returns><c>true</c> if the target board slot is available; otherwise, <c>false</c> </returns>
    public bool IsValidMove(ConsoleKey key)
    {
        if (key == ConsoleKey.NumPad7 && Board[0, 0] == ' ' || key == ConsoleKey.D7 && Board[0, 0] == ' ') return true;
        if (key == ConsoleKey.NumPad8 && Board[0, 1] == ' ' || key == ConsoleKey.D8 && Board[0, 1] == ' ') return true;
        if (key == ConsoleKey.NumPad9 && Board[0, 2] == ' ' || key == ConsoleKey.D9 && Board[0, 2] == ' ') return true;
        if (key == ConsoleKey.NumPad4 && Board[1, 0] == ' ' || key == ConsoleKey.D4 && Board[1, 0] == ' ') return true;
        if (key == ConsoleKey.NumPad5 && Board[1, 1] == ' ' || key == ConsoleKey.D5 && Board[1, 1] == ' ') return true;
        if (key == ConsoleKey.NumPad6 && Board[1, 2] == ' ' || key == ConsoleKey.D6 && Board[1, 2] == ' ') return true;
        if (key == ConsoleKey.NumPad1 && Board[2, 0] == ' ' || key == ConsoleKey.D1 && Board[2, 0] == ' ') return true;
        if (key == ConsoleKey.NumPad2 && Board[2, 1] == ' ' || key == ConsoleKey.D2 && Board[2, 1] == ' ') return true;
        if (key == ConsoleKey.NumPad3 && Board[2, 2] == ' ' || key == ConsoleKey.D3 && Board[2, 2] == ' ') return true;
        return false;
    }

    /// <summary>
    /// Translates user key to relative board index.
    /// </summary>
    /// <param name="key">key is a ConsoleKey representing a number from 1 to 9.</param>
    /// <returns>A tuple for 0-based (row, col) coordinates for a 3x3 board.</returns>
    public void Update(ConsoleKey key, char avatar)
    {
        if (key == ConsoleKey.NumPad7 || key == ConsoleKey.D7) Board[0, 0] = avatar;
        if (key == ConsoleKey.NumPad8 || key == ConsoleKey.D8) Board[0, 1] = avatar;
        if (key == ConsoleKey.NumPad9 || key == ConsoleKey.D9) Board[0, 2] = avatar;
        if (key == ConsoleKey.NumPad4 || key == ConsoleKey.D4) Board[1, 0] = avatar;
        if (key == ConsoleKey.NumPad5 || key == ConsoleKey.D5) Board[1, 1] = avatar;
        if (key == ConsoleKey.NumPad6 || key == ConsoleKey.D6) Board[1, 2] = avatar;
        if (key == ConsoleKey.NumPad1 || key == ConsoleKey.D1) Board[2, 0] = avatar;
        if (key == ConsoleKey.NumPad2 || key == ConsoleKey.D2) Board[2, 1] = avatar;
        if (key == ConsoleKey.NumPad3 || key == ConsoleKey.D3) Board[2, 2] = avatar;
    }

    /// <summary>
    /// Determines if horizontal, vertical, or diagonal char values in a single line are the same.
    /// </summary>
    /// <param name="avatar">The char value to check against.</param>
    /// <returns><c>true</c> if the provided avatar populates every element in a horizontal, vertical or diagonal line in the array; otherwise <c>false</c> </returns>
    public bool HasWinner(char avatar)
    {
        // Horizontal win conditions
        if (Board[0, 0] == avatar && Board[0, 1] == avatar && Board[0, 2] == avatar) return true;
        if (Board[1, 0] == avatar && Board[1, 1] == avatar && Board[1, 2] == avatar) return true;
        if (Board[2, 0] == avatar && Board[2, 1] == avatar && Board[2, 2] == avatar) return true;
        // Vertical win conditions
        if (Board[0, 0] == avatar && Board[1, 0] == avatar && Board[2, 0] == avatar) return true;
        if (Board[0, 1] == avatar && Board[1, 1] == avatar && Board[2, 1] == avatar) return true;
        if (Board[0, 2] == avatar && Board[1, 2] == avatar && Board[2, 2] == avatar) return true;
        // Diagonal win conditions
        if (Board[0, 0] == avatar && Board[1, 1] == avatar && Board[2, 2] == avatar) return true;
        if (Board[2, 0] == avatar && Board[1, 1] == avatar && Board[0, 2] == avatar) return true;

        return false;
    }
}