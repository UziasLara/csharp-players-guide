/// <summary>
/// Manages a Fountain of Objects game
/// </summary>
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
        Console.Title = "The Fountain of Objects";
        
        Renderer.DisplayIntroduction();

        ISense[] senses =
        {
            new FountainSense(),
            new EntranceSense(),
            new PitSense(),
            new MonsterSense()
        };

        Renderer.DisplayHelper();

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

            if (command == null) continue; // break early if command is invalid.

            foreach (Monster monster in Monsters)
            {
                if (monster.Point == Player.Point)
                {
                    if (monster is Maelstrom && monster.IsAlive)
                    {
                        monster.Encounter(this);
                        Renderer.PrettyPrint(monster.EncounterMessage, ConsoleColor.Blue);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    if (monster is Amarok) monster.Encounter(this);
                }
            }
            if (Board.GetRoomAt(Player.Point) == Room.Pit)
            {
                Player.Kill("You've fallen into a pit!");
            }


        }
        if (HasWinner) Renderer.PrettyPrint("The Fountain of Objects has been reactivated, and you have escaped with your life!\nYou win!", ConsoleColor.Green);
        else Renderer.PrettyPrint($"{Player.DeathMessage}\nGame Over", ConsoleColor.Red);

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
            "shoot north" => new AttackCommand(Direction.North),
            "shoot south" => new AttackCommand(Direction.South),
            "shoot east" => new AttackCommand(Direction.East),
            "shoot west" => new AttackCommand(Direction.West),
            "help" => new HelperCommand(),
            "show intro" => new GameIntroCommand(),

            _ => null
        };
    }
}