using System.Text;

List<object> objects = new List<object>();

objects.Add(GetInputFromUser<int>("Please enter an integer: "));
objects.Add(GetInputFromUser<double>("Please enter a double: "));
objects.Add(GetInputFromUser<bool>("Please enter a boolean: "));
objects.Add(GetInputFromUser<string>("Please enter a string: ")); // Won't immediately break, will add an empty string.
objects.Add(GetInputFromUser<bool>("Please enter a boolean: "));
StringBuilder text = new StringBuilder();
text.Append("You Entered: ");

foreach (Object obj in objects)
{
    text.Append(obj);
    text.Append(" ");
}
Console.WriteLine(text);


/// Gets an int, a double, or a boolean from the user returns default type value if neither. 
static T GetInputFromUser<T>(string message)
{
    object result = default(T)!;
    bool isValid = false;
    while (true)
    {
        Console.Write(message);
        string input = Console.ReadLine() ?? string.Empty;

        if (typeof(T) != typeof(int) && typeof(T) != typeof(double) && typeof(T) != typeof(bool)) return (T)result;
        if (typeof(T) == typeof(int))
        {
            isValid = int.TryParse(input, out int value);
            result = value;
        }
        else if (typeof(T) == typeof(double))
        {
            isValid = double.TryParse(input, out double value);
            result = value;
        }
        else if (typeof(T) == typeof(bool))
        {
            isValid = bool.TryParse(input, out bool value);
            result = value;
        }
        if (isValid) return (T)result;
    }
}

