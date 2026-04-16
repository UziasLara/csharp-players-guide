string gameSize = InputManager.GetInput("Would you like to play a small (4x4), medium (6x6), or large (8x8) game? ");

GameManager? game = gameSize switch
{
    "small" => SmallGame(),
    "medium" => MediumGame(),
    "large" => LargeGame(),
    _ => null
};

game?.Run();

// Returns a small 4x4 Fountain of Objects game
// with 1 Pit and 1 Maelstrom
GameManager SmallGame()
{
    Monster[] monsters =
    {
        new Maelstrom(new Point(3,3))
    };
    GameManager smallGame = new(new Board(4, 4), new Player(), monsters);
    smallGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    smallGame.Board.SetRoomAt(new Point(0, 2), Room.Fountain);
    smallGame.Board.SetRoomAt(new Point(3, 1), Room.Pit);
    return smallGame;
}

// Returns a medium 6x6 Fountain of Objects game
// with 1 Pit, 1 Maelstrom, and 2 Amaroks
GameManager MediumGame()
{
    Monster[] monsters =
{
        new Maelstrom(new Point(3, 3)),
        new Amarok(new Point(4, 5)),
        new Amarok(new Point(5,1))
    };
    GameManager mediumGame = new(new Board(6, 6), new Player(), monsters);
    mediumGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    mediumGame.Board.SetRoomAt(new Point(2, 4), Room.Fountain);
    mediumGame.Board.SetRoomAt(new Point(4, 4), Room.Pit);
    return mediumGame;
}

// Returns a large 8x8 Fountain of Objects game
// with 1 Pit, 2 Maelstroms, and 3 Amaroks.
GameManager LargeGame()
{
    Monster[] monsters =
{
        new Maelstrom(new Point(5, 5)),
        new Maelstrom( new Point(1, 1)),
        new Amarok(new Point(1, 3)),
        new Amarok(new Point(3, 6)),
        new Amarok(new Point(7, 3))
    };

    GameManager largeGame = new(new Board(8, 8), new Player(), monsters);
    largeGame.Board.SetRoomAt(new Point(0, 0), Room.Entrance);
    largeGame.Board.SetRoomAt(new Point(4, 6), Room.Fountain);
    largeGame.Board.SetRoomAt(new Point(6, 7), Room.Pit);
    return largeGame;
}
