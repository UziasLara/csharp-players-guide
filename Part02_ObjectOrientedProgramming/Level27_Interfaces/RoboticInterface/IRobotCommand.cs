/// <summary>
/// Represents the base class from which subsequent command classes will derive.
/// </summary>
interface IRobotCommand
{
    void Run(Robot robot);
}
/// <summary>
/// A command to represetn a robot's on state
/// </summary>
class OnCommand : IRobotCommand
{
    public void Run(Robot robot) => robot.IsPowered = true;
}
/// <summary>
/// A command to represetn a robot's off state
/// </summary>
class OffCommand : IRobotCommand
{
    public void Run(Robot robot) => robot.IsPowered = false;
}
/// <summary>
/// A command to represetn a robot's northward movement
/// </summary>
class NorthCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) ++robot.Y; }
}
/// <summary>
/// A command to represetn a robot's southward movement
/// </summary>
class SouthCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) --robot.Y; }
}
/// <summary>
/// A command to represetn a robot's eastward movement
/// </summary>
class EastCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) ++robot.X; }
}
/// <summary>
/// A command to represetn a robot's westward movement
/// </summary>
class WestCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) --robot.X; }
}
