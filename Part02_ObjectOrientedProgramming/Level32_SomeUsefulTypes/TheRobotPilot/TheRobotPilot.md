## The Robot Pilot

**How could object oriented programming be used to allow the game to run as either in single or multiplayer mode?**

> By creating two classes, Singleplayer and Multiplayer which derive from IGameMode, we could declare the following and easily switch back and forth between the game modes.
>```csharp
>// Depending on which object is created, we can choose the game mode to proceed with.
>IGameMode gameMode = new Singleplayer();
>// IGameMode gameMode = new Multiplayer();
>int manticore = gameMode.GetNumber();
>
>interface IGameMode { int GetNumber(); }
>
>class Multiplayer : IGameMode { public int GetNumber() => Convert.ToInt32(Console.ReadLine()); }
>
>class Singleplayer : IGameMode { public int GetNumber() => new Random().Next(1, 100); }
