/// <summary>
/// Represents the main character in The Fountain of Objects game.
/// </summary>
class Player : Entity
{
    public int ArrowCount { get; private set; } = 5;
    
    //public void MoveBy(Point point) => this.Point =new Point(this.Point.Row + point.Row, this.Point.Col + point.Col);

    public void Kill(string deathMessage)
    {
        base.Kill();
        DeathMessage = deathMessage;
    }

    public void SpendArrow() => ArrowCount--;
    

}