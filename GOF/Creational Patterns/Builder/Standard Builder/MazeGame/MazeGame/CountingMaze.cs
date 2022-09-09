namespace MazeGame;

public class CountingMaze
{
    public int Doors { get; private set; }
    public int Rooms { get; private set; }

    public CountingMaze(int doors, int rooms)
    {
        Doors = doors;
        Rooms = rooms;
    }
}