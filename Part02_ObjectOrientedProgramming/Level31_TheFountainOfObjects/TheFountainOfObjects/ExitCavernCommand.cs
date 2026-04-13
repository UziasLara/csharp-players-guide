/// <summary>
/// Represents the command to exit the cavern.
/// </summary>
class ExitCavernCommand : ICommand
{
    /// <summary>
    /// Checks if exit is allowed and executes the <see cref="IGameWorld"/> object's ToggleWinner() method. 
    /// </summary>
    /// <param name="world"><see cref="IGameWorld"/> object in which to execute this command. </param>
    public void Execute(IGameWorld world)
    {
        if(world.IsFountainEnabled == true && world.Board.GetRoomAt(world.Player.Point) == Room.Entrance)
        {
            world.ToggleWinner();
        }
        else
        {
            Console.WriteLine("The Fountain of Objects has yet to be reactivated.\nYou cannot leave!.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}