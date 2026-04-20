/// <summary>
/// Represents a class that "harvests" fruit from the Charberry Tree class when new fruit is ripe.
/// </summary>
class Harvester
{
    int _harverstCount;
    CharberryTree _tree;
    public Harvester(CharberryTree tree)
    {
        tree.Ripened += OnRipened;
        _tree = tree;
    }
    public void OnRipened()
    {
        _tree.Ripe = false;
        _harverstCount++;
        Console.WriteLine($"Charberry Tree fruit has been harvested {_harverstCount} times.");
    }
}