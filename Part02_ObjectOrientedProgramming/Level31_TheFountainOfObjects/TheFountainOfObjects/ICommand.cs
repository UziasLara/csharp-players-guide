using System.Data;


/// <summary>
/// Base class to build game commands upon
/// </summary>
interface ICommand
{
    void Execute(IGameWorld gameWorld);
}

/// <summary>
/// Calls Renderer.DisplayHelper via world's ShowHelp() method
/// </summary>
class HelperCommand : ICommand
{
    public void Execute(IGameWorld world)
    {
        world.ShowHelp();
    }
}




