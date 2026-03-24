// Write a program that takes in a base and height values.
// Compute and display the area of the triangle based on the formula: 
// Area = (base * height) / 2 
// 100\x1b[1m and \x1b[0m bolds text.
// Disclaimer: For simplicity, this code has no checks.

Console.Write("What is the \x1b[1mBase\x1b[0m of your triangle? ");
float triangleBase = Convert.ToSingle(Console.ReadLine());
Console.Write("What is the \x1b[1mHeight\x1b[0m of your triangle? ");
float triangleHeight = Convert.ToSingle(Console.ReadLine());

// Compute triangle area
float area = (triangleBase * triangleHeight) / 2f;
Console.WriteLine();
Console.WriteLine($"The \x1b[1mArea\x1b[0m of the triangle based on the values provided is: {area:N}");