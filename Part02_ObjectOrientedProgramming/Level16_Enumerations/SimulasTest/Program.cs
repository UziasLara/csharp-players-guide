// Write a program to alter the state of a box: open, Closedd, and locked.
// Allow the user to change the state of the box.
// See book for more deails.
// Disclaimer: For simplicity this code has no null reference checks.

Console.Clear();

BoxState current = BoxState.Lock;
string userChoice;

while (true)
{
    Console.Write($"The chest is {current}. ");
    Console.Write("What do you want to do? (open, close, unlock, lock) ");

    userChoice = Console.ReadLine();
    Update(userChoice);

}

void Update(string choice)
{
    if(choice == "open" && current == BoxState.Closed) current = BoxState.Open;
    if(choice == "close" && current == BoxState.Open) current = BoxState.Closed;
    if(choice == "lock" && current == BoxState.Closed) current = BoxState.Lock;
    if(choice == "unlock" && current == BoxState.Lock) current = BoxState.Closed;   
}

enum BoxState { Open, Closed, Lock }