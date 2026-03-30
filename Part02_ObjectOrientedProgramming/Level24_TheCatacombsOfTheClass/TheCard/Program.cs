// Create a Card class that represents a card composed of a color and rank.
// In the main method, create an instance of the Card class for every card that would make up a deck.
// Display each card to the terminal.
// See book for specifics.

DisplayDeck();

// Display every possible card from the Card class.
void DisplayDeck()
{
    // Create arrays to hold the enum values
    Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow };
    Rank[] ranks = 
    { 
        Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, 
        Rank.Currency, Rank.Percent, Rank.Caret, Rank.Ampersand 
    };

    // Loop through the number of colors available and for each color loop again for each rank.
    // Create a new instance of Card for the current Color and Rank.
    foreach (Color color in colors)
    {
        foreach (Rank rank in ranks)
        {
            Card card = new Card(color, rank);

            if (card.IsSymbol) Console.WriteLine($"The {card.Name} is a Symbol card.");
            else Console.WriteLine($"The {card.Name} is a Number card.");
        }
    }
}
class Card
{
    public string Name { get; }
    public bool IsSymbol => _rank > Rank.Ten;
    public bool IsNumber => !IsSymbol;
    private Color _color;
    private Rank _rank;
    public Card (Color color, Rank rank)
    {
        _color = color;
        _rank = rank;
        Name = $"{_color} {_rank}";
    }
}
// Declare enums to represent color, and rank for each card.
// Initialize their order starting from 1.
enum Color { Red = 1, Green, Blue, Yellow }
enum Rank { One = 1, Two, Three, Four, Five,Six, Seven, Eight, Nine, Ten, Currency, Percent, Caret, Ampersand }