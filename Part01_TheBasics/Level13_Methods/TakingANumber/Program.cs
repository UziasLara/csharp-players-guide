// Write a method for getting a number from the user
// Write a method for getting a number within range from the user.

int age = AskForNumber("How old are you: ");
int number = AskForNumberInRange("Please provide a number between 1 and 10 (inclusive): ", 1, 10);

Console.WriteLine($"Your age is {age}.");

string message = number % 2 == 0 ? "even" : "odd";
Console.WriteLine($"Your number is {message}.");

int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    int userNumber;
    do
    {
        Console.Write(text);
        userNumber = Convert.ToInt32(Console.ReadLine());

    } while(userNumber < min || userNumber > max);

    return userNumber;
}

