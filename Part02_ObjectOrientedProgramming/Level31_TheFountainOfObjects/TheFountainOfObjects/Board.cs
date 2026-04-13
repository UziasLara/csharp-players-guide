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
}






