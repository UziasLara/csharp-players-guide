/// <summary>
/// Abstract Monster representation
/// </summary>
abstract class Monster : Entity
{
    public string EncounterMessage { get; protected set; } = string.Empty;
    public Monster(Point point)
    {
        MoveTo(point);
    }
    public abstract void Encounter(IGameWorld world);
    public override void Kill()
    {
        DeathMessage = $"{this.GetType().Name} has been slayed.";
        IsAlive = false;
    }
}