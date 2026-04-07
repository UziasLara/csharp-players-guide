/// <summary>
/// Represents a wrapper that associates an underlying item <typeparamref name="T"/> with a <see cref="ConsoleColor"/>.
/// </summary>
/// <typeparam name="T">The type of underlying item</typeparam>
class ColoredItem<T>
{
    public T Item { get; }
    public ConsoleColor Color { get; }
    /// <summary>Initializes a new <see cref="ColoredItem{T}"/>.</summary>
    /// <param name="item">The value to store.</param>
    /// <param name="color">The color for terminal output.</param>
    public ColoredItem(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    } 

    /// <summary>
    /// Displays the item to the terminal using the assigned <see cref="Color"/>
    /// </summary>
    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
        Console.ResetColor();
    }
}