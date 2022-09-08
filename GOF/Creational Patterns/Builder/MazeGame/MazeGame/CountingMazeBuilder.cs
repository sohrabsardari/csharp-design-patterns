namespace MazeGame;

public class CountingMazeBuilder : IMazeBuilder
{
    private int _rooms;
    private int _doors;
    public void BuildDoor(int from, int to)
    {
        _doors++;
    }

    public void BuildRoom(int room)
    {
        _rooms++;
    }

    public CountingMaze GetCounts()
    {
        return new CountingMaze(_doors, _rooms);
    }
}