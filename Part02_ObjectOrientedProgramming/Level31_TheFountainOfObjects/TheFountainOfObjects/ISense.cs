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
/// Represents the Entrance ISense to display to the user based on <see cref="IGameWorld"/> status.
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
/// <summary>
/// Represents the Pit ISense to display to the user based on <see cref="IGameWorld"/> status. 
/// </summary>
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
/// <summary>
/// Represents the Monster ISense to display to the user based on <see cref="IGameWorld"/> status. 
/// </summary>
class MonsterSense : ISense
{
    public void Execute(IGameWorld world)
    {
        Point player = world.Player.Point;

        string alert = string.Empty;

        foreach (Monster monster in world.Monsters)
        {
            if (world.Board.AreAllAroundAdjacent(player, monster.Point))
            {
                if (monster is Maelstrom) alert = "You hear the growling and groaning of a maelstron nearby.";
                else if (monster is Amarok) alert = "You smell the rotten stench of an amarok in a nearby room.";
                Console.WriteLine(alert);
            }
            
        }
    }
}

