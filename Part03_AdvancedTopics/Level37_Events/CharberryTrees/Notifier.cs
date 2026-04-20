/// <summary>
/// Represents a class which notifies upon ripened fruit from the CharberryTree class.
/// </summary>
class Notifier
{
    public Notifier(CharberryTree tree) => tree.Ripened += OnRipened;
    public void OnRipened() => Console.WriteLine("A Charberry fruit has ripened!");
}