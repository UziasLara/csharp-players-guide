string gameSize = InputManager.GetInput("Would you like to play a small (4x4), medium (6x6), or large (8x8) game?");

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
    GameManager smallGame = new(new Board(4, 4), new Player());
    smallGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    smallGame.Board.SetRoomAt(new Point(0, 2), Room.Fountain);
    return smallGame;
}

GameManager MediumGame()
{
    GameManager mediumGame = new(new Board(6, 6), new Player());
    mediumGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    mediumGame.Board.SetRoomAt(new Point(2, 4), Room.Fountain);
    return mediumGame;
}
GameManager LargeGame()
{

    GameManager largeGame = new(new Board(8, 8), new Player());
    largeGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    largeGame.Board.SetRoomAt(new Point(4, 6), Room.Fountain);
    return largeGame;
}
