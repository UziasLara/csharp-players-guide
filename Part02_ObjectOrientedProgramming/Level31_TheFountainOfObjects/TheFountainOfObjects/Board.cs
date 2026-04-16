/// <summary>
/// Represents the Board in which the game will take place.
/// </summary>
class Board
{
    public Room[,] Rooms { get; }
    public Board(int row, int col)
    {
        Rooms = new Room[row, col];
    }
    /// <summary>
    /// Set the room type at an assigned Point
    /// </summary>
    /// <param name="point">The <see cref="Point"/> at which to set the room</param>
    /// <param name="room">The type of <see cref="Room"/> to be set</param>
    public void SetRoomAt(Point point, Room room)
    {
        if (IsOnBoard(point)) Rooms[point.Row, point.Col] = room;
        else Console.WriteLine("Out of bounds.");
    }
    /// <summary>
    /// Get the room at <see cref="Point"/>
    /// </summary>
    /// <param name="point">Point to check for <see cref="Room"/> type.</param>
    /// <returns><see cref="Room"/></returns>
    public Room GetRoomAt(Point point) => IsOnBoard(point) ? Rooms[point.Row, point.Col] : Room.None;

    public bool IsOnBoard(Point point) =>
        point.Row >= 0 && point.Row < Rooms.GetLength(0) &&
        point.Col >= 0 && point.Col < Rooms.GetLength(1);

    public bool IsAdjacentTo(Point point, Room room)
    {
        if (GetRoomAt(new Point(point.Row - 1, point.Col)) == room) return true;
        if (GetRoomAt(new Point(point.Row + 1, point.Col)) == room) return true;
        if (GetRoomAt(new Point(point.Row, point.Col - 1)) == room) return true;
        if (GetRoomAt(new Point(point.Row, point.Col + 1)) == room) return true;
        return false;

    }

    public bool AreAllAroundAdjacent(Point source, Point target)
    {
        int rowDiff = Math.Abs(source.Row - target.Row);
        int colDiff = Math.Abs(source.Col - target.Col);

        if (rowDiff == 0 && colDiff == 0) return false;

        return (rowDiff) <= 1 && (colDiff) <= 1;
    }

    public Point Clamp(Point point)
    {
        int row = Math.Clamp(point.Row, 0, Rooms.GetLength(0) -1 );
        int col = Math.Clamp(point.Col, 0, Rooms.GetLength(1) -1);

        return new Point(row, col);
    }
}






