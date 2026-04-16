class Player : Entity
{
    public string DeathMessage { get; private set; } = string.Empty;
    //public void MoveBy(Point point) => this.Point =new Point(this.Point.Row + point.Row, this.Point.Col + point.Col);

    public void Kill(string deathMessage)
    {
        base.Kill();
        DeathMessage = deathMessage;
    }

}