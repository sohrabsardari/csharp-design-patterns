namespace MazeGame;

public class Director
{
    private readonly IMazeBuilder _builder;

    public Director(IMazeBuilder builder)
    {
        _builder = builder;
    }

    public void BuildSimpleMaze()
    {
        _builder.BuildRoom(1);
        _builder.BuildRoom(2);
        _builder.BuildRoom(3);
        _builder.BuildDoor(1,2);
        _builder.BuildDoor(2,3);
    }

    public void BuildComplexMaze()
    {
        _builder.BuildRoom(1);
        _builder.BuildRoom(2);
        _builder.BuildRoom(3);
        //............
        _builder.BuildRoom(1000);

        _builder.BuildDoor(1, 2);
        _builder.BuildDoor(2, 3);
        //.........
    }
}