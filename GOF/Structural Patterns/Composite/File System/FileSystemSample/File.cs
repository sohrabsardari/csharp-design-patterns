namespace FileSystemSample;

public class File : FileSystem
{
    private readonly int _size;
    public File(int size)
    {
        _size = size;
    }
    public override int GetSize()
    {
        return _size;
    }
}