// Write a program to command The Old Robot
// See book for details

Console.Clear();
Console.Title = "The Old Robot";

Robot robot = new Robot();

for (int i = 0; i < robot.Commands.Length; i++)
{
    Console.Write("Please enter your command for the robot (on, off, north, south, east, west): ");
    string? command = Console.ReadLine();
    robot.Commands[i] = command switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
        _ => null
    };
}
robot.Run();
