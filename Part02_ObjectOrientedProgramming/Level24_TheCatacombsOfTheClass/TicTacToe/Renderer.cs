/// <summary>
/// Displays helper boards for the game of Tic-Tac-Toe
/// </summary>
class Renderer
{
    /// <summary>
    /// Displays every element in a 2D <c>char</c> array in the format of Tic-Tac-Toe
    /// </summary>
    /// <param name="board">The <c>char[,]</c> representing the current game state.</param>
    public void DisplayBoard (char[,] board)
    {
        for ( int i = 0; i < board.GetLength(0); i++ )
        {
            for ( int j = 0; j < board.GetLength(1); j++ )
            {
                Console.Write($" {board[i,j]}");
                if ( j != board.GetLength(1) -1 ) Console.Write($" |");   
            }
            Console.WriteLine();
            if (i != board.GetLength(0) - 1 ) Console.WriteLine("---+---+---");
        }
    }
    /// <summary>
    /// Displays a static Tic-Tac-Toe board with cell values indicating respective cell number.
    /// </summary>
    public void DisplayHelper()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Map your selection to the given key.");

        Console.WriteLine(" 7 | 8 | 9 ");
        Console.WriteLine("---+---+---");
        Console.WriteLine(" 4 | 5 | 6 ");
        Console.WriteLine("---+---+---");
        Console.WriteLine(" 1 | 2 | 3 ");    
        Console.WriteLine("-------------------------------------");    
    }
}