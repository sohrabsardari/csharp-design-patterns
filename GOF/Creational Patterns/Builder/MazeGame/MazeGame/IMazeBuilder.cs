namespace MazeGame;

public interface IMazeBuilder
{
    void BuildDoor(int from, int to);
    void BuildRoom(int room);
}