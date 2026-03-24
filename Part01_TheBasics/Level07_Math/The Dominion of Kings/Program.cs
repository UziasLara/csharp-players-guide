// Write a program that intakes the number of provinces, duchies, and estates each kingdom has.
// Tally up each domain accoding to the following point system.
// Estate = 1 point, Duchy = 3 points, Province = 6 points.
// Display the total point value of the kingdom.
// Disclaimer: For simplicity, this code has no checks.

int estateBaseValue = 1;
int duchyBaseValue = 3;
int provinceBaseValue = 6;


Console.Write("Please enter the number of estates: ");
int numberOfEstates = Convert.ToInt32(Console.ReadLine());
int totalEstateValue = estateBaseValue*numberOfEstates;

Console.Write("Please enter the number of duchies: ");
int numberOfDuchies = Convert.ToInt32(Console.ReadLine());
int totalDuchyValue = duchyBaseValue*numberOfDuchies;

Console.Write("Please enter the number of provinces: ");
int numberOfProvinces = Convert.ToInt32(Console.ReadLine());
int totalProvinceValue = provinceBaseValue*numberOfProvinces;

int totalKingdomValue = totalEstateValue + totalDuchyValue + totalProvinceValue;

Console.WriteLine($"Estate Value: {totalEstateValue}");
Console.WriteLine($"Duchy Value: {totalDuchyValue}");
Console.WriteLine($"Province Value: {totalProvinceValue}");
Console.WriteLine($"Kingdom Total Value: {totalKingdomValue}");