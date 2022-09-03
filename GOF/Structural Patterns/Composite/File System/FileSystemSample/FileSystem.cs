namespace FileSystemSample
{
    public abstract class FileSystem
    {
        public abstract int GetSize();

        public virtual void AddChild(FileSystem fileSystem)
        {
            // Do nothing
        }
    }
}