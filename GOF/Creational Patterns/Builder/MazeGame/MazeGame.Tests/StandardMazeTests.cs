using Xunit;

namespace MazeGame.Tests
{
    public class StandardMazeTests
    {
        [Fact]
        public void creating_simple_maze()
        {
            var standardMazeBuilder = new StandardMazeBuilder();
            var director = new Director(standardMazeBuilder);
            director.BuildSimpleMaze();

            var simpleStandardMaze = standardMazeBuilder.GetMaze();
        }

        [Fact]
        public void creating_complex_maze()
        {
            var standardMazeBuilder = new StandardMazeBuilder();
            var director = new Director(standardMazeBuilder);
            director.BuildComplexMaze();

            var complexStandardMaze = standardMazeBuilder.GetMaze();
        }
    }
}