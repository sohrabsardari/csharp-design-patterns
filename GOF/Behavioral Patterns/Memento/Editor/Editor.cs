namespace Editor;

public class Editor
{
    public string Content { get; private set; }

    public EditorState CreateState()
    {
        return new EditorState(this.Content);
    }

    public void Restore(EditorState state)
    {
        this.Content = state.Content;
    }

    public void SetContent(string content)
    {
        this.Content += content;
    }
}