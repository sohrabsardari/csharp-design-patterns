namespace FileSystemSample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void creating_a_composite_structure()
        {
            var root = new Directory();
            var file1 = new File(1000);
            var file2 = new File(2000);
            root.AddChild(file2);
            root.AddChild(file1);
            var subDirectory = new Directory();
            subDirectory.AddChild(file1);
            root.AddChild(subDirectory);

            var sizeOfRoot = root.GetSize();

            Assert.Equal(4000, sizeOfRoot);
        }
    }
}