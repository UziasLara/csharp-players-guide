/// <summary>
/// Base class used to represent game objects, such as Entity.
/// </summary>
class GameObject { }
/// <summary>
/// Represents the base class from which Monster and Player are derived.
/// </summary>
class Entity : GameObject
{
    public Point Point { get; private set; }
    public bool IsAlive { get; protected set; } = true;
    public string DeathMessage { get; protected set; } = string.Empty;
    public void MoveTo(Point point) => this.Point = point;

    //public void MoveBy(Point point) => this.Point =new Point(this.Point.Row + point.Row, this.Point.Col + point.Col);
    public string GetPositionLabel() => $"(Row={Point.Row}, Column={Point.Col})";
    public virtual void Kill() => IsAlive = false;
}