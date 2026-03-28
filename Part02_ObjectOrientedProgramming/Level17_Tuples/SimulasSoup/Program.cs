// Write a program that stores three enumerated 'soup' ingredients in a tuple.
// Let the user decide which ingredients will go in the soup.
// Display the soup in the format: Sweet Chicken Gumbo 
// See book for more details.
// Disclaimer: For simplicity, this code has no input checks.

var meal = GetIngredients();

Console.WriteLine($"Your piping hot {meal.seasoning} {meal.ingredient} {meal.broth} is ready!");

// Get the ingredients for making the intended soup.
(Broth broth, Ingredient ingredient, Seasoning seasoning) GetIngredients()
{
    int broth, ingredient, seasoning;
    Console.WriteLine("Please choose your preferred broth");
    Console.WriteLine("1. Soup | 2. Stew | 3. Gumbo");
    broth = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please choose the main ingredient.");
    Console.WriteLine("1. Mushrooms | 2. Chicken | 3. Carrots | 4. Potatoes");
    ingredient = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please choose your seasoning kind.");
    Console.WriteLine("1. Spicy | 2. Salty | 3. Sweet");
    seasoning = Convert.ToInt32(Console.ReadLine());

    return ((Broth)broth, (Ingredient)ingredient, (Seasoning)seasoning);
}


enum Broth { Soup = 1, Stew = 2, Gumbo = 3 }
enum Ingredient { Mushrooms = 1, Chicken = 2, Carrot = 3, Potatoe = 4 }
enum Seasoning { Spicy = 1, Salty = 2, Sweet = 3 }