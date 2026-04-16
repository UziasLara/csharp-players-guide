class Amarok : Monster
{
    public Amarok(Point point) : base(point)
    {
        
    }

    public override void Encounter(IGameWorld world)
    {
        world.Player.Kill("You've been wasted by an Amarok.");
    }
}