interface ISense
{
    void Execute(IGameWorld gameWorld);
}
/// <summary>
/// Represents the Fountain ISense to display to the user based on <see cref="IGameWorld"/> status.
/// </summary>
class FountainSense : ISense
{
    public void Execute(IGameWorld world)
    {
        bool isAtFountain = world.Board.GetRoomAt(world.Player.Point) == Room.Fountain;
        bool isFountainEnabled = world.IsFountainEnabled;

        if (isAtFountain)
        {
            string message = isFountainEnabled ?
                "You hear the rushing waters from the Fountain of Objects. It has been reactivated!" :
                "You hear water dripping in this room. The Fountain of Objects is here!";

            Console.WriteLine(message);

        }
    }
}
/// <summary>
/// Represents the Entrance ISense to display to the user based on <see cref="IGameWord"/> status.
/// </summary>
class EntranceSense : ISense
{
    public void Execute(IGameWorld world)
    {
        if (world.Board.GetRoomAt(world.Player.Point) == Room.Entrance)
        {
            Console.WriteLine("You see light coming from the cavern entrance.");
        }
    }
}

class PitSense : ISense
{
    public void Execute(IGameWorld world)
    {
        if (world.Board.IsAdjacentTo(world.Player.Point, Room.Pit))
        {
            Console.WriteLine("You feel a draft. There is a pit in a nearby room.");
        }
    }
}

class MaelstromSense : ISense
{
    public void Execute(IGameWorld world)
    {
        Point player = world.Player.Point;

        foreach (Monster monster in world.Monsters)
        {
            if (monster is Maelstrom && world.Board.AreAllAroundAdjacent(player, monster.Point))
            {
                Console.WriteLine("You hear the growling and groaning of a maelstron nearby");
                break;
            }
        }
    }
}

