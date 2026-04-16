class GameObject {}
class Entity : GameObject
{
    public Point Point { get; private set; }
    public bool IsAlive { get; private set; } = true;
    public void MoveTo(Point point) => this.Point = point;

    //public void MoveBy(Point point) => this.Point =new Point(this.Point.Row + point.Row, this.Point.Col + point.Col);
    public string GetPositionLabel() => $"(Row={Point.Row}, Column={Point.Col})";
    public void Kill() => IsAlive = false;
}

class Monster : Entity
{
    public Monster(Point point)
    {
        MoveTo(point);
    }


}