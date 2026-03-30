// Update Vin Fletcher's Trouble challenge by setting the Arrow class' fields to private.
// Add getter methods to each field.
// Disclaimer: For simplicity, this code has no input checks.

var userArrow = GetUserArrow();

Arrow arrow = new Arrow(userArrow.Arrowhead, userArrow.Fletching, userArrow.Length);

Console.WriteLine("---------------------------------");
Console.WriteLine($"Your {arrow.GetLength()}cm {arrow.GetArrowhead()} and {arrow.GetFletching()} arrow costs {arrow.GetPrice()} gold.");

// Intake and compute user arrow preferences.
(Arrowhead Arrowhead, Fletching Fletching, float Length) GetUserArrow()
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

    return (userArrowhead, userFletching, arrowLength);
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
    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private float _length;
    private decimal _pricePerCM = 0.05m;
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public Arrowhead GetArrowhead() => _arrowhead;
    public Fletching GetFletching() => _fletching;
    public float GetLength() => _length;
    public decimal GetPricePerCM() => _pricePerCM;

    // Uses enum indexes as price indexes
    public decimal GetPrice() => ((int)_arrowhead + (int)_fletching + ((decimal)_length * _pricePerCM));
}


// Define enum with indexes as prices.
enum Arrowhead { Steel = 10, Wood = 3, Obsidian = 5 }
enum Fletching { Plastic = 10, TurkeyFeather = 5, GooseFeather = 3}