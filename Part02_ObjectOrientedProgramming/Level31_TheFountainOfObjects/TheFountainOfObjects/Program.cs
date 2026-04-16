string gameSize = InputManager.GetInput("Would you like to play a small (4x4), medium (6x6), or large (8x8) game? ");

GameManager? game = gameSize switch
{
    "small" => SmallGame(),
    "medium" => MediumGame(),
    "large" => LargeGame(),
    _ => null
};

game?.Run();


GameManager SmallGame()
{
    Monster[] monsters =
    {
        new Maelstrom(new Point(3,3))
    };
    GameManager smallGame = new(new Board(4, 4), new Player(), monsters);
    smallGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    smallGame.Board.SetRoomAt(new Point(0, 2), Room.Fountain);
    smallGame.Board.SetRoomAt(new Point(3,1), Room.Pit);
    return smallGame;
}

GameManager MediumGame()
{
        Monster[] monsters =
    {
        new Maelstrom(new Point(3,3))
    };
    GameManager mediumGame = new(new Board(6, 6), new Player(), monsters);
    mediumGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    mediumGame.Board.SetRoomAt(new Point(2, 4), Room.Fountain);
    mediumGame.Board.SetRoomAt(new Point(4, 4), Room.Pit);
    return mediumGame;
}
GameManager LargeGame()
{
        Monster[] monsters =
    {
        new Maelstrom(new Point(5,5))
    };

    GameManager largeGame = new(new Board(8, 8), new Player(), monsters);
    largeGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    largeGame.Board.SetRoomAt(new Point(4, 6), Room.Fountain);
    largeGame.Board.SetRoomAt(new Point(3, 2), Room.Pit);
    return largeGame;
}
