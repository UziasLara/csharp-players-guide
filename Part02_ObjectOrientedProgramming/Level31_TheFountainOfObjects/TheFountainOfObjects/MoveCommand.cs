class MoveCommand : ICommand
{
    readonly Direction _direction;

    /// <summary>
    /// Initialize startup state
    /// </summary>
    /// <param name="direction"><see cref="Direction"/> in which to move.</param>
    public MoveCommand(Direction direction) => _direction = direction;
    /// <summary>
    /// Execute this command and move player to next Point
    /// </summary>
    /// <param name="world"><see cref="IGameWorld"/> object in which to perform this command.</param>
    public void Execute(IGameWorld world)
    {
        Point next = NextPoint(world.Player.Point);

        if (world.Board.IsOnBoard(next)) world.Player.MoveTo(next);
    }
    /// <summary>
    /// Calculates Point to move to
    /// </summary>
    /// <param name="original">The starting <see cref="Point"/> reference to use as the base for calculation./param>
    /// <returns>A new <see cref="Point"/> with the appropriate move direction.</returns>
    Point NextPoint(Point original)
    {
        int stepSize = 1;
        
        return _direction switch
        {
            Direction.North => new Point(original.Row - stepSize, original.Col),
            Direction.South => new Point(original.Row + stepSize, original.Col),
            Direction.East => new Point(original.Row, original.Col + stepSize),
            Direction.West => new Point(original.Row, original.Col - stepSize),
            _ => new Point(0, 0)
        };
    }

    
}