// Modify the program to discount the given price by 50% if the name input matches yours.
// Write a program that displays a list of items.
// Prompt the user to choose an item from the list and display its respective price.
// Disclaimer: For simplicity, this code has no input checks.

Console.Write("Welcome to Tortuga's Shop!\nWho are we serving today?: ");
string name = Console.ReadLine();
float discount = 0.50f;

Console.WriteLine();
Console.WriteLine($"Hello {name}, the following items are available:");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("1 -- Rope");
Console.WriteLine("2 -- Torches");
Console.WriteLine("3 -- Climbing Equipment");
Console.WriteLine("4 -- Clean Water");
Console.WriteLine("5 -- Machete");
Console.WriteLine("6 -- Canoe");
Console.WriteLine("7 -- Food Supplies");
Console.WriteLine("----------------------------------------------");

Console.Write("What number do you want to see the price of? ");
int userInput = Convert.ToInt32(Console.ReadLine());

string item = userInput switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "NotAnItem"
};

float price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1,
    _ => 999_999_999
};

if (name == "Uzias") price *= discount;
if (item != "NotAnItem")
{
    Console.WriteLine($"{item} costs {price} gold.");
}
else
{
    Console.WriteLine("That is not a valid selection.");
}