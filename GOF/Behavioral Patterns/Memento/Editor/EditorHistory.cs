namespace Editor;

public class EditorHistory
{
    private Stack<EditorState> _history = new();

    public void Push(EditorState state)
    {
        _history.Push(state);
    }


    public EditorState Undo()
    {
        _history.Pop();
        return _history.Peek();
    }
}