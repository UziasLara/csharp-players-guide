// Write a program that takes a number from player 1 from 0 to 100.
// Clear the screen and prompt player 2 to guess the number. 
// Loop until player 2 guess correctly

int target;
do
{
    Console.Write("Player 1, enter the target number from 0 to 100: ");
    target = Convert.ToInt32(Console.ReadLine());

}while(target < 0 || target >100);

Console.Clear();
Console.WriteLine("Player 2, guess the number.");

int guess;
do
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

    if(guess > target) Console.WriteLine($"{guess} is too high.");
    else if (guess < target) Console.WriteLine($"{guess} is too low.");
    
} while(guess != target);

Console.WriteLine("You guessed the number!");