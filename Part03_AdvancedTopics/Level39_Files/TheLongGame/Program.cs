// Counts every keystroke and adds +1 to player's score except Enter, which ends count.
// Writes final score to player's score file.

string userScore;
string fileName;
string? name;
int score = 0;

Console.Write("What's your name? ");
name = Console.ReadLine() ?? "Player 1";
fileName = $"{name}.txt";

if (File.Exists(fileName))
{
    Console.WriteLine($"Welcome back {name}!");
    userScore = File.ReadAllText(fileName);
    score = Convert.ToInt32(userScore);
}


while (true)
{
    Console.WriteLine($"Your current score is {score}");
    ConsoleKey key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.Enter) break;

    score++;
}

File.WriteAllText(fileName, Convert.ToString(score));