// Create a program that uses extension methods on the Random class.
// See book for more details.

double myDouble = new Random().NextDouble(10);
string direction = new Random().NextString("up", "down", "left", "right");
bool isItHeads = new Random().CoinFlip();
bool isItHeads25 = new Random().CoinFlip(0.25);

Console.WriteLine($"Double: {myDouble}\nDirection: {direction}\nIs it heads? (50% chance): {isItHeads}\nIs it heads? (25% chance) {isItHeads25}");
