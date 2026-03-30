// Modify Vin's Trouble challenge to use properties instead of getter and setter methods.
// Disclaimer: For simplicity, this code has no input checks.

VinsShop();

void VinsShop()
{
    Console.Clear();
    Console.WriteLine("Welcome to Vin Fletcher's arrows!");
    Console.WriteLine("---------------------------------------------------------------------");
    Console.WriteLine("What kind of arrow would you like?");
    Console.WriteLine("1. Elite Arrow: Steel arrowhead, Plastic fletching, 95cm");
    Console.WriteLine("2. Marksman Arrow: Steel arrowhead, Goose Feather fletching, 65cm");
    Console.WriteLine("3. Beginner Arrow: Wood arrowhead, Goose Feather fletching, 75cm");
    Console.WriteLine("4. Create custom arrow.");

    int userChoice = Convert.ToInt32(GetUserInput("What kind of arrow would you like? "));

    Arrow arrow = userChoice switch
    {
        1 => Arrow.CreateEliteArrow(),
        2 => Arrow.CreateMarksmanArrow(),
        3 => Arrow.CreateBeginnerArrow(),
        _ => CreateCustomArrow()
    };

    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Your {arrow.Length}cm {arrow.Arrowhead} and {arrow.Fletching} arrow costs {arrow.Price} gold.");
}

// Intake and compute user arrow preferences.
Arrow CreateCustomArrow()
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

// Ensure user input is within range
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

    // Factory Methods
    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, Fletching.Plastic, 95f);
    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeather, 65f);
    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeather, 75f);
}

// Define enum with indexes as prices.
enum Arrowhead { Steel = 10, Wood = 3, Obsidian = 5 }
enum Fletching { Plastic = 10, TurkeyFeather = 5, GooseFeather = 3}