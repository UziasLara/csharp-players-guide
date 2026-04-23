// Allow the user to create a Potion based on ingredients chosen.
// Using pattern matching, create and display the potion.
// See book for details.

Potion userPotion = Potion.Water;

while (true)
{
    Console.Clear();
    Console.WriteLine($"Your Potion: {userPotion}");
    Console.WriteLine("-------------------");
    Console.WriteLine("Available ingredients:\n");
    Console.WriteLine("Stardust\nSnake Venom\nDragon Breath\nShadow Glass\nEyeshine Gem\n");

    Console.Write($"Choose an ingredient, or enter 'discard' or CTRL + D to start over: ");

    string? choice = Console.ReadLine()?.ToLower().Trim();

    if (choice is "discard" or null)
    {
        userPotion = Potion.Water;
        continue;
    }
    //  Try parsing user choice and replacing white space so that ingredients such as Sha dowG lass become ShadowGlass.
    //  Makes the comparison case insensitive such that sHaDoW gLaSs or similar also match.
    if (!Enum.TryParse(choice?.Replace(" ", ""), true, out Ingredient ingredient))
    {
        // Fallback case
        Console.WriteLine($"Invalid selection: {choice}\nPress any key to continue: ");
        Console.ReadKey();
        continue;
    }

    userPotion = (userPotion, ingredient) switch
    {
        (Potion.Water, Ingredient.Stardust)             => Potion.Elixir,
        (Potion.Elixir, Ingredient.SnakeVenom)          => Potion.Poison,
        (Potion.Elixir, Ingredient.DragonBreath)        => Potion.Flying,
        (Potion.Elixir, Ingredient.ShadowGlass)         => Potion.Invisibility,
        (Potion.Elixir, Ingredient.EyeshineGem)         => Potion.NightSight,
        (Potion.NightSight, Ingredient.ShadowGlass) or 
        (Potion.Invisibility, Ingredient.EyeshineGem)   => Potion.Cloudy,
        (Potion.Cloudy, Ingredient.Stardust)            => Potion.Wraith,
        _                                               => Potion.Ruined
    };
}

enum Ingredient { Water, Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem }
enum Potion { Water, Elixir, Poison, Flying, Invisibility, NightSight, Cloudy, Wraith, Ruined }