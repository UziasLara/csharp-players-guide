/// <summary>
/// Manages running logic for the game of Tic-Tac-Toe
/// </summary>
class TicTacToeGame
{
    public Player PlayerO { get; }
    public Player PlayerX { get; }
    private bool _hasWinner;
    private readonly int _maxTurns = 9;
    public GameBoard Board { get; }
    public Renderer Renderer { get; }
    public TicTacToeGame(Player playerO, Player playerX, GameBoard board, Renderer renderer)
    {
        PlayerO = playerO;
        PlayerX = playerX;
        Board = board;
        Renderer = renderer;
    }

    /// <summary>
    /// Runs a game of Tic-Tac-Toe
    /// </summary>
    public void Run()
    {
        Player currentPlayer = PlayerO;

        Console.Clear();

        Renderer.DisplayBoard(Board.Board);
        int round = 1;
        while(round <= _maxTurns)
        {
            Console.Clear();
            Renderer.DisplayBoard(Board.Board);
            Console.WriteLine($"Player {currentPlayer.Avatar}, it is your turn.");
            ConsoleKey key = currentPlayer.GetKey("Where would you like to place your avatar? ");
            Console.WriteLine();

            if (key == ConsoleKey.H)
            {
                Renderer.DisplayHelper();
                Console.Write("Press any key to continue: ");
                Console.ReadKey();
            }
            else if (Board.IsValidMove(key))
            {
                Board.Update(key, currentPlayer.Avatar);
                _hasWinner = Board.HasWinner(currentPlayer.Avatar);

                if(_hasWinner) break;
                currentPlayer = currentPlayer == PlayerO ? PlayerX : PlayerO;
                round++;
            }
            else 
            { 
                Console.WriteLine("That spot is taken!\nPress any key to continue: ");
                Console.ReadKey();                
            }
        }
        Console.Clear();

        string message = _hasWinner ? $"Congratulations {currentPlayer.Avatar}! You've won this round" : "Alas, it's a draw...";
        Console.WriteLine(message);
        Renderer.DisplayBoard(Board.Board);
    }
}