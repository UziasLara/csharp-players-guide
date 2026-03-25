// Write a program that computes the cardinal direction a coordinate is relative to the watchtower's coordinate at (0,0).
// Please refer to the book example for visual hints.
// Disclaimer: For simplicity, this code has no input checks.

Console.Write("Enter x value: ");
int enemyX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y value");
int enemyY = Convert.ToInt32(Console.ReadLine());

string cardinalDirection = "";

if (enemyY > 0) cardinalDirection += "N";
if (enemyY < 0) cardinalDirection += "S";
if (enemyX < 0) cardinalDirection += "W";
if (enemyX > 0) cardinalDirection += "E";
if (enemyX == 0 && enemyY == 0) cardinalDirection = "!";

if (cardinalDirection != "!")
{
    Console.WriteLine($"The enemy approaches from the {cardinalDirection}");
}
else
{
    
    Console.WriteLine($"The enemy has reached the tower!");
}