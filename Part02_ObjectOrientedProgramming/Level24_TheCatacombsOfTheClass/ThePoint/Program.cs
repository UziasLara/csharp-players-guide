// Define a new Point class (x,y).
// Add a parameterless constructor to create an origen point (0,0).
// Add a constructor to create a point at any x- and y- coordinates.

Point origin = new Point();
Point target1 = new Point(2,3);
Point target2 = new Point(-4,0);

Console.WriteLine($"The origin is at ({origin.X}, {origin.Y}).");
Console.WriteLine($"The first target is at ({target1.X}, {target1.Y}).");
Console.WriteLine($"The second target is at ({target2.X}, {target2.Y}).");
class Point
{
    public int X { get; }
    public int Y { get; }
    public Point() : this(0,0) {}
    public Point(int x, int y)
    {
        X = x; Y = y;
    }
}