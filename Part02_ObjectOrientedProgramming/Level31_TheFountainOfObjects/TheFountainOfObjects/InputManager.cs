/// <summary>
/// Represents a way to obtain user input.
/// </summary>
class InputManager
{
    public static string GetInput(string text)
    {
        while (true)
        {
            Console.Write(text);
            string? rawInput = Console.ReadLine();
            if (rawInput != null) return rawInput;
        }
    }
}