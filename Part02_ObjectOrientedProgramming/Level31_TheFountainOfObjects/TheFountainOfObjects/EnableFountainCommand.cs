class EnableFountainCommand : ICommand
{
    public void Execute(IGameWorld world)
    {
        if (world.Board.GetRoomAt(world.Player.Point) == Room.Fountain)
        {
            world.EnableFountain();
        }
    }
}