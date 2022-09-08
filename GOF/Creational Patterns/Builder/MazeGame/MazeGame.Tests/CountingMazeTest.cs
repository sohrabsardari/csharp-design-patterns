using Xunit;

namespace MazeGame.Tests;

public class CountingMazeTest
{
    [Fact]
    public void create_simple_counting_maze()
    {
        var countingMazeBuilder = new CountingMazeBuilder();
        var director = new Director(countingMazeBuilder);
        director.BuildSimpleMaze();

        var complexCountingMaze = countingMazeBuilder.GetCounts();

        //Some assertion
    }
    [Fact]
    public void create_complex_counting_maze()
    {
        var countingMazeBuilder = new CountingMazeBuilder();
        var director = new Director(countingMazeBuilder);
        director.BuildComplexMaze();

        var complexCountingMaze = countingMazeBuilder.GetCounts();

        //Some assertion
    }
}