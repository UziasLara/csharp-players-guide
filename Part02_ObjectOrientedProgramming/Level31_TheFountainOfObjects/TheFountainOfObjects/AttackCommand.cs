/// <summary>
/// Represents a Player's attack actions
/// </summary>
class AttackCommand : ICommand
{
    public Direction _direction;
    public AttackCommand(Direction direction) => _direction = direction;
    public void Execute(IGameWorld world)
    {
        int arrowCount = world.Player.ArrowCount;
        if (arrowCount <= 0)
        {
            Console.WriteLine("You're out of arrows!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        Point next = TargetDirection(world.Player.Point);
        Monster[] monsters = world.Monsters;
        if (world.Board.IsOnBoard(next))
        {
            foreach (Monster monster in monsters)
            {
                if (monster.Point == next)
                {
                    monster.Kill();
                    Renderer.PrettyPrint(monster.DeathMessage, ConsoleColor.Green);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                }
            }
        }
        
        world.Player.SpendArrow();

    }
    /// <summary>
    /// Returns a new Point representing an attack's target direction.
    /// </summary>
    /// <param name="source">Source of the attack.</param>
    /// <returns>A new <see cref="Point"/> with calculated attack direction.</returns>
    Point TargetDirection(Point source)
    {
        int range = 1;

        return _direction switch
        {
            Direction.North => new Point(source.Row - range, source.Col),
            Direction.South => new Point(source.Row + range, source.Col),
            Direction.East => new Point(source.Row, source.Col + range),
            Direction.West => new Point(source.Row, source.Col - range),
            _ => new Point(-1, -1)
        };
    }
}
