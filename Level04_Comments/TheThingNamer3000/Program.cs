/* 
Rebuild the program shown in the book
Comment the purpose of each variable
*/

Console.WriteLine("What kind of thing are we talking about?");
// Item/noun
string? a = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// Item adjetive
string? b = Console.ReadLine();

// Item fluff
string c = "of Doom";
// Item version
string d = "3000";

Console.WriteLine($"The {b} {a} {c} {d}!");