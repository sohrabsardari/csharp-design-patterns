namespace MazeGame;

public interface IMazeBuilder
{
    void BuildDoor(int from, int to);
    void BuildRoom(int room);
    Maze Build();
}

public class Maze
{
}

public class StandardMazeBuilder : IMazeBuilder
{
    public void BuildDoor(int from, int to)
    {
        Console.WriteLine($"Build a standard door {from} to {to}");
    }

    public void BuildRoom(int room)
    {
        Console.WriteLine($"Build a standard room {room}");
    }

    public Maze Build()
    {
        Console.WriteLine("returning the standard maze that you built");
        return new Maze();
    }
}

public class NumericMazeBuilder : IMazeBuilder
{
    public void BuildDoor(int from, int to)
    {
        throw new NotImplementedException();
    }

    public void BuildRoom(int room)
    {
        throw new NotImplementedException();
    }

    public Maze Build()
    {
        throw new NotImplementedException();
    }
}

public class Director
{
    private readonly IMazeBuilder _builder;

    public Director(IMazeBuilder builder)
    {
        _builder = builder;
    }

    public Maze CreateStandardMaze()
    {
        _builder.BuildRoom(1);
        _builder.BuildRoom(2);
        _builder.BuildRoom(3);
        _builder.BuildDoor(1,2);
        _builder.BuildDoor(2,3);
        return _builder.Build();
    }
}