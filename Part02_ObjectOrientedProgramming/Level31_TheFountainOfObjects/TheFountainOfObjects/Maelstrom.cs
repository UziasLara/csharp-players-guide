/// <summary>
/// Represents a Maelstrom Monster that displaces the player when encountered.
/// </summary>
class Maelstrom : Monster
{
    public Maelstrom(Point point) : base(point) { }
    public override void Encounter(IGameWorld world)
    {
        // Initialize next Point to 1-unit south and 2-units west
        Point next = new Point(world.Player.Point.Row + 1, world.Player.Point.Col - 2);
        world.Player.MoveTo(world.Board.Clamp(next));

        EncounterMessage = $"You were moved to: {world.Player.GetPositionLabel()} by the maelstrom.";
    }
}