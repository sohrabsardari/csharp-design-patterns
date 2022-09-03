namespace FileSystemSample;

public class Directory : FileSystem
{
    private IList<FileSystem> _fileSystem = new List<FileSystem>();
    public override int GetSize()
    {
        return _fileSystem.Sum(a => a.GetSize());
    }

    public override void AddChild(FileSystem fileSystem)
    {
        this._fileSystem.Add(fileSystem);
    }
}