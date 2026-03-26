// Write a method that counts down from 10 to 1 using recursion.

Countdown(10);

void Countdown(int start)
{
    if(start <= 0)
    {
        return;
    }
    Console.WriteLine(start);
    Countdown(start-1);
}