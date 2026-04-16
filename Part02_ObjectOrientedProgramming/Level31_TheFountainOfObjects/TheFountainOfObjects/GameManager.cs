class GameManager : IGameWorld
{
    public Board Board { get; }
    public Player Player { get; }
    public bool IsFountainEnabled { get; private set; }
    public bool HasWinner { get; private set; }
    public Monster[] Monsters { get; private set; }

    public GameManager(Board board, Player player, Monster[] monsters)
    {
        Board = board;
        Player = player;
        Monsters = monsters;
    }

    /// <summary>
    /// Starts a game of The Fountain of Objects game
    /// </summary>
    public void Run()
    {
        ISense[] senses =
        {
            new FountainSense(),
            new EntranceSense(),
            new PitSense(),
            new MaelstromSense()
        };

        ShowHelp();

        while (Player.IsAlive && !HasWinner)
        {
            Console.Clear();
            Renderer.DisplayPlayer(Player);

            foreach (ISense sense in senses)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                sense.Execute(this);
                Console.ResetColor();
            }
            string action = InputManager.GetInput("What would you like to do? ");


            ICommand? command = GetCommand(action);
            command?.Execute(this);

            foreach (Monster monster in Monsters)
            {
                if (monster is Maelstrom && Player.Point == monster.Point)
                {
                    // Initialize next Point to 1-unit south and 2-units west
                    Point next = new Point(Player.Point.Row + 1, Player.Point.Col - 2);
                    Player.MoveTo(Board.Clamp(next));
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You were moved to: {Player.GetPositionLabel()} by the maelstrom.");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
            if (Board.GetRoomAt(Player.Point) == Room.Pit)
            {
                Player.Kill("You've fallen into a pit!");
            }


        }
        if (HasWinner)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!\nYou win!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Player.DeathMessage);
            Console.WriteLine("Gave Over");
        }

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