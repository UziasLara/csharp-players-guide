// Write a program in which two players take turns picking a number from 0 - 9 (inclusive).
// If the computer generated number is picked, they lose the game.
// Use try catch blocks to handle a thrown exception when the computer generated number is picked.
// See book for details.
// Disclaimer: For simplicity this book has minimal checks.

int raisinCookie = new Random().Next(10);
List<int> numbers = new List<int>();
string currentPlayer = "Player 1";

while (true)
{
    int cookie = GetIntFromPlayer($"{currentPlayer}, please pick a number from 0 to 9: ", 0, 10);
    if (numbers.Contains(cookie))
    {
        cookie = GetIntFromPlayer("That number has already been picked. Pick a different number: ", 0, 10);
    }
    try
    {
        if (cookie == raisinCookie)
        {
            throw new RaisinCookieException("Picked the oatmeal raisin cookie!");
        }
    }
    catch (RaisinCookieException)
    {
        Console.WriteLine($"You ate the raisin cookie {currentPlayer}. Gross!\nJk I love oatmeal raisin cookies.");
        currentPlayer = currentPlayer == "Player 1" ? "Player 2" : "Player 1";
        break;
    }
    currentPlayer = currentPlayer == "Player 1" ? "Player 2" : "Player 1";
}

Console.WriteLine($"You were the last player standing {currentPlayer}. You win!");

// Return an integer supply by the user.
int GetIntFromPlayer(string prompt, int min, int max)
{
    Console.WriteLine(prompt);
    int input = Convert.ToInt32(Console.ReadLine());

    while (input < min || input >= max)
    {
        Console.WriteLine("That number is out of range. Please pick another: ");
        input = Convert.ToInt32(Console.ReadLine());
    }
    return input;
}







