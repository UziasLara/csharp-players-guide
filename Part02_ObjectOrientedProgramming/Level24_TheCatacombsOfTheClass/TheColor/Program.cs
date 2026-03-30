// Write a program that represents a Color class with channels for Red, Green, and Blue. 
// Create eight different static Color properties that represent common colors.
// Display a custom and a fixed color.
// See book for more details.

Color blue = Color.Blue;
Color cyan = new Color(0, 255, 255);

Console.WriteLine($"The color blue consists of ({blue.R}, {blue.G}, {blue.B}).");
Console.WriteLine($"The color cyan consists of ({cyan.R}, {cyan.G}, {cyan.B}).");

class Color
{
    // static fixed Color properties
    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);

    // Color channels
    public byte R { get; }
    public byte G { get; }
    public byte B { get; }
    public Color(byte red,  byte green,  byte blue)
    {
        R = red;
        G = green;
        B = blue;
    }
}