// Create a Sword, Bow, and Axe classes and using a generic class display each with a different ConsoleColor.
// See book for details

ColoredItem <Sword> blueSword = new(new Sword(), ConsoleColor.Blue);
ColoredItem <Bow> redBow = new(new Bow(), ConsoleColor.Red);
ColoredItem <Axe> greenAxe = new(new Axe(), ConsoleColor.Green);

blueSword.Display();
redBow.Display();
greenAxe.Display();
