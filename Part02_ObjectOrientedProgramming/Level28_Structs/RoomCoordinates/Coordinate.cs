/// <summary>
/// Represents a coordinate in 2D-space using Row and Col positions.
/// </summary>
readonly struct Coordinate
{
    int Row { get; }
    int Col { get; }

    public Coordinate(int row, int col) { Row = row; Col = col; }
    public bool IsAdjacent(Coordinate coordinate)
    {
        if (this.Row == coordinate.Row + 1 && this.Col == coordinate.Col) return true;
        if (this.Row == coordinate.Row - 1 && this.Col == coordinate.Col) return true;
        if (this.Row == coordinate.Row && this.Col == coordinate.Col + 1) return true;
        if (this.Row == coordinate.Row && this.Col == coordinate.Col - 1) return true;
        
        return false;
    }
}