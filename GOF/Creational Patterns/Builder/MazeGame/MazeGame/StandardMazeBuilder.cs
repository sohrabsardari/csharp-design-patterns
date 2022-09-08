namespace MazeGame;

public class StandardMazeBuilder : IMazeBuilder
{
    private List<Door> _doors = new List<Door>();
    private List<Room> _rooms = new List<Room>();
    public void BuildDoor(int from, int to)
    {
        Console.WriteLine($"Build a standard door {from} to {to}");
        _doors.Add(new Door(from,to));
    }

    public void BuildRoom(int room)
    {
        Console.WriteLine($"Build a standard room {room}");
        _rooms.Add(new Room(room));
    }

    public StandardMaze GetMaze()
    {
        Console.WriteLine("returning the standard maze that you built");
        return new StandardMaze(_doors, _rooms);
    }
}

public class Room
{
    public int RoomId { get; private set; }

    public Room(int roomId)
    {
        RoomId = roomId;
    }
}

public class Door
{
    public int From { get; private set; }
    public int To { get; private set; }

    public Door(int from, int to)
    {
        From = from;
        To = to;
    }
}