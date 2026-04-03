// Write a program that can store a multitude of items in a pack according to its constraints.
// See book for further details.
// For simplicity, this code contains minimal input checks.

Run();

void Run()
{
    int capacity = 10;
    float weight = 10;
    float volume = 10;

    Pack Backpack = new Pack(capacity, weight, volume);

    while (true)
    {
        Console.Clear();

        DisplayPack(Backpack);
        Console.WriteLine("You have the following items available to take with you");
        DisplayItems();
        int selection = GetItem("What would you like to add to your pack (digit)? ");

        if (selection == 7)
        {
            Console.Write("Are you sure you want to RESET your pack? (y/n) ");
            if (Console.ReadLine() == "y")
            {
                Backpack = new Pack(capacity, weight, volume);
            }
            continue;
        }
        InventoryItem? item = selection switch
        {
            1 => new Arrow(),
            2 => new Bow(),
            3 => new Sword(),
            4 => new Water(),
            5 => new Food(),
            6 => new Rope(),
            _ => null
        };

        if (item != null)
        {
            if (!Backpack.Add(item))
            {
                Console.WriteLine("Your pack can't hold that.");
                Console.WriteLine("Press any key to continue: ");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}

// Display the contents of current pack
void DisplayPack(Pack pack)
{
    Console.WriteLine("My pack:");
    Console.WriteLine($"Weight:{pack.Weight}/{pack.MaxWeight} | Volume:{pack.Volume}/{pack.MaxVolume} | Items: {pack.ItemsInPack}/{pack.MaxItems}");
}

// Gets selection from user
int GetItem(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Display available items
void DisplayItems()
{
    Console.WriteLine($"1.{"",-4}Arrow");
    Console.WriteLine($"2.{"",-4}Bow");
    Console.WriteLine($"3.{"",-4}Sword");
    Console.WriteLine($"4.{"",-4}Water");
    Console.WriteLine($"5.{"",-4}Food");
    Console.WriteLine($"6.{"",-4}Rope");
    Console.WriteLine($"7.{"",-4}RESET");
}