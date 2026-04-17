// Modify the Robotic Interface challenge (lvl-27) to use List<T> instead of arrays.
// Write a program to command The Old Robot
// See book for details

Console.Clear();
Console.Title = "The Old Robot";

Robot robot = new Robot();

while (true)
{
    Console.Write("Please enter your command for the robot (on, off, north, south, east, west): ");
    string? command = Console.ReadLine();

    if (command == "stop") break;

    IRobotCommand? robotCommand = command switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
        _ => null
    };

    if (robotCommand != null) robot.Commands.Add(robotCommand);

}
robot.Run();
