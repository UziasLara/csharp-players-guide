// Write a program that intakes a manticore number from player 1 and allows player 2 to playerGuess the number.
// Every turn player 2 takes 1 point of damage for a maximum of 15 points if player 1 is still alive.
// If the turn is divisible by 3, 5, or both, respectively deal 3, 3, or 10 points of damage to player 1; deal 1 point of damage otherwise.
// Winning conditions: Player 1 wins if it deals 15 points of damage to player 2. Player 2 wins if it deals 10 points of damage to player 1.
// Refer to the book for further guidance.
// For simplicity, this code has no checks.

// Setup starting values
int cityHP = 15;
int manticoreHP = 10;
int round =1;

// Placeholder turn-by-turn data
int playerGuess = 0;
int manticore = 0;

Run();

// Run the game
void Run()
{
    // Get Manticore's position from player
    Console.Write("Player 1, how far should the Manticore be from the city? ");
    manticore = GetPlayerNumber();

    Console.Clear();
    Console.WriteLine("Player 2, it is your turn.");

    while(cityHP > 0 && manticoreHP > 0) // Run as long as the city and the manticore stand.
    {
        Console.WriteLine("----------------------------------");
        DisplayStatus(round, cityHP, manticoreHP);
        Console.WriteLine($"The cannon is expected to deal {GetRoundDamage(round)} this round.");
        Console.Write("Enter a desired cannon range: ");
        playerGuess = GetPlayerNumber();

        DisplayHit(playerGuess, manticore);

        ResolveDamage(round);
        round++;
    }
    
    DisplayResults();
}

// Check whether the game meets winning conditions.
bool HasWinner() => (cityHP > 0 && manticoreHP <=0);

// Check if user playerGuess the manticore's position correctly.
bool IsHit() => playerGuess == manticore;

// Update city and manticore health based on the current turn.
void ResolveDamage(int round)
{
    if(IsHit()) manticoreHP -= GetRoundDamage(round); // Decrease Manticore HP if hit.
    if(manticoreHP > 0) cityHP--; // Decrease city HP if the Manticore is still alive.
}

// Display end of game message.
void DisplayResults()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (HasWinner()) Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You tried your hardest, yet it was not enough. The City of Consolas is no more...");
    }
    Console.ResetColor();
}

// Display whether the player playerGuessed correctly.
void DisplayHit(int playerGuess, int manticore)
{
    Console.ForegroundColor = ConsoleColor.Red;
    if(playerGuess > manticore) Console.WriteLine("That round \u001b[1mOVERSHOT\u001b[0m the manticore.");    
    else if (playerGuess < manticore) Console.WriteLine("That round \u001b[1mUNDERSHOT\u001b[0m the manticore.");         
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a \u001b[1mDIRECT HIT!\u001b[0m");
    }
    Console.ResetColor();
} 

// Display current round stats.
void DisplayStatus(int round, int cityHP, int manticoreHP)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"\u001b[1mSTATUS | Round: {round} | City: {cityHP}/15 | Manticore: {manticoreHP}/10 \u001b[0m");      
    Console.ResetColor();
}

// Ask the player for a number.
int GetPlayerNumber() => Convert.ToInt32(Console.ReadLine()); 

// Compute damage output based on current round.
int GetRoundDamage(int turn) 
{
    bool isFire = round % 3 == 0;
    bool isElectric = round % 5 == 0;

    if ( isFire && isElectric) return 10;
    else if (isFire || isElectric) return 3;
    return 1;
}