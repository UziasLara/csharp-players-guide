/// <summary>
/// Represents an interface of necessary world objects.
/// </summary>
interface IGameWorld
{
    Board Board { get; }
    Player Player { get; }
    Monster[] Monsters { get; }
    bool IsFountainEnabled { get; }
    void ToggleWinner();
    void EnableFountain();
    void ShowHelp();

}