// Create an arrow class that creates arrows based on material preferences.
// Compute the cost and display the details for each arrow created.
// See book for specific details.
// Disclaimer: For simplicity, this code has no input checks.

var userArrow = GetUserArrow();

Arrow arrow = new Arrow(userArrow.Arrowhead, userArrow.Fletching, userArrow.Length);

Console.WriteLine("---------------------------------");
Console.WriteLine($"Your {userArrow.Length}cm {userArrow.Arrowhead} and {userArrow.Fletching} arrow costs {arrow.GetPrice()} gold.");

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
    Arrowhead _arrowhead;
    Fletching _fletching;
    float _length;
    decimal _pricePerCM = 0.05m;
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    // Uses enum indexes as price indexes
    public decimal GetPrice() => ((int)_arrowhead + (int)_fletching + ((decimal)_length * _pricePerCM));
}


// Define enum with indexes as prices.
enum Arrowhead { Steel = 10, Wood = 3, Obsidian = 5 }
enum Fletching { Plastic = 10, TurkeyFeather = 5, GooseFeather = 3}