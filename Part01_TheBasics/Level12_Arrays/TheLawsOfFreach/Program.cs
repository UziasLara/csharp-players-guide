// Using foreach loops, compute the average and smallest value in the provided array: { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Begin with the highest possible int

foreach(int value in array)
{
    if(value <= currentSmallest) currentSmallest = value;
}
Console.WriteLine(currentSmallest);

int total = 0;

foreach(int value in array)
{
    total += value;
}

float average = (float)total / array.Length;
Console.WriteLine(average);