// Modify Vin's Trouble challenge to use properties instead of getter and setter methods.
// Disclaimer: For simplicity, this code has no input checks.

Arrow arrow = GetArrow();

Console.WriteLine("---------------------------------");
Console.WriteLine($"Your {arrow.Length}cm {arrow.Arrowhead} and {arrow.Fletching} arrow costs {arrow.Price} gold.");

// Intake and compute user arrow preferences.
Arrow GetArrow()
{
    Console.Clear();
    string userInput;
    
    userInput = GetUserInput("What kind of arrowhead would you like? (steel, wood, or obsidian) ");
    Arrowhead userArrowhead = userInput switch
    {
        "steel" => Arrowhead.Steel,
        "obsidian" => Arrowhead.Obsidian,
        _ => Arrowhead.Wood,
    };

    userInput = GetUserInput("What kind of fletching would you like? (plastic, goose feather, turkey feather) ");
    Fletching userFletching = userInput switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feather" => Fletching.TurkeyFeather,
        _ => Fletching.GooseFeather
    };

    Console.Write("We can make your arrow between 60 and 100 cm. How long would you like it to be? ");
    float arrowLength = GetLengthInRange(60,100);

    return new Arrow(userArrowhead, userFletching, arrowLength);
}

// Prompt user for input
string GetUserInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

float GetLengthInRange(float min, float max)
{
    while(true)
    {
        float length = Convert.ToSingle(Console.ReadLine());
        if (length >= min && length <= max) return length;
        Console.Write("Invalid length. Try again: ");
    }
}
class Arrow
{
    public Arrowhead Arrowhead { get;}
    public Fletching Fletching { get; }
    public float Length { get; }
    public decimal PricePerCM { get; init; } = 0.05m;
    public decimal Price  => ((int)Arrowhead + (int)Fletching + ((decimal)Length * PricePerCM));
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }
    // Uses enum indexes as price indexes
}


// Define enum with indexes as prices.
enum Arrowhead { Steel = 10, Wood = 3, Obsidian = 5 }
enum Fletching { Plastic = 10, TurkeyFeather = 5, GooseFeather = 3}