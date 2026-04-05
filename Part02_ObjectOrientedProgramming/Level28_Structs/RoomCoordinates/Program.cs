// Create a Coordinate struct and method to determine if two coordinates are adjacent.

Coordinate origin = new Coordinate(0,0);

Coordinate north = new Coordinate(-1, 0);
Coordinate south = new Coordinate(1, 0);
Coordinate east = new Coordinate(0,1);
Coordinate west = new Coordinate(0,-1);


Coordinate northwest = new Coordinate(-1, -1);
Coordinate southeast = new Coordinate(1, 1);

Console.WriteLine(origin.IsAdjacent(origin)); // false
Console.WriteLine();
Console.WriteLine(origin.IsAdjacent(north)); // true
Console.WriteLine(origin.IsAdjacent(south)); // true
Console.WriteLine(origin.IsAdjacent(east)); // true
Console.WriteLine(origin.IsAdjacent(west)); // true
Console.WriteLine();
Console.WriteLine(origin.IsAdjacent(northwest)); // false
Console.WriteLine(origin.IsAdjacent(southeast)); // false

