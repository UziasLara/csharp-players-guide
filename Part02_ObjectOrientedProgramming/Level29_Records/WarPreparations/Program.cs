// Create a Sword record composed of a Material, Gemstone, Length and Crossguard Width.
// Create 3 Swords and display their qualities.

Sword ironSword = new Sword(Material.Iron, Gemstone.None, 65, 15);
Sword bronzeEmerald = ironSword with { Material = Material.Bronze, Gemstone =Gemstone.Emerald };
Sword BinariumBitsone = ironSword with { Material = Material.Binarium, Gemstone = Gemstone.Bitstone, Length = 95 };

Console.WriteLine(ironSword);
Console.WriteLine(bronzeEmerald);
Console.WriteLine(BinariumBitsone);


