namespace MazeGame;

public class StandardMaze
{
    public List<Door> Doors { get; private set; }
    public List<Room> Rooms { get; private set; }

    public StandardMaze(List<Door> doors, List<Room> rooms)
    {
        Doors = doors;
        Rooms = rooms;
    }
}