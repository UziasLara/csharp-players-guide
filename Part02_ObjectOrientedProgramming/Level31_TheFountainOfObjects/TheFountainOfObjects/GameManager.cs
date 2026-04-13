class GameManager : IGameWorld
{
    public Board Board { get; }
    public Player Player { get; }
    public bool IsFountainEnabled { get; private set; }
    public bool HasWinner { get; private set; }
    public GameManager(Board board, Player player)
    {
        Board = board;
        Player = player;
    }
    
    /// <summary>
    /// Starts a game of The Fountain of Objects game
    /// </summary>
    public void Run()
    {        
        ISense[] senses =
        {
            new FountainSense(),
            new EntranceSense()
        };
        
        ShowHelp();

        while (!HasWinner)
        {
            Console.Clear();
            Renderer.DisplayPlayer(Player);

            foreach (ISense sense in senses)
            {
                sense.Execute(this);
            }
            string action = InputManager.GetInput("What would you like to do? ");


            ICommand? command = GetCommand(action);
            command?.Execute(this);

        }
        Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!\nYou win!");
    }
    /// <summary>
    /// Sets state of Fountain to true/false
    /// </summary>
    public void EnableFountain() => IsFountainEnabled = !IsFountainEnabled;

    /// <summary>
    /// Sets state of HasWinner to true/false
    /// </summary>
    public void ToggleWinner() => HasWinner = !HasWinner;
        
    
    /// <summary>
    /// Gets the appropriate command based on user input.
    /// </summary>
    /// <param name="action">a <see cref="string"/> representing the action to take.</param>
    /// <returns></returns>
    ICommand? GetCommand(string action)
    {
        return action switch
        {
            "move north" => new MoveCommand(Direction.North),
            "move south" => new MoveCommand(Direction.South),
            "move east" => new MoveCommand(Direction.East),
            "move west" => new MoveCommand(Direction.West),
            "enable fountain" => new EnableFountainCommand(),
            "exit cavern" => new ExitCavernCommand(),
            "help" => new HelperCommand(),

            _ => null
        };
    }
    /// <summary>
    /// Calls Renderer's <see cref="Renderer.DisplayHelper"/> method to display useful commands to the user.
    /// </summary>
    public void ShowHelp() => Renderer.DisplayHelper();

}