public class Document
{
    public State State { get; private set; }

    public Document()
    {
        this.State = new Draft();
    }
    public void Render()
    {
        this.State = this.State.Render();
    }
    public void Publish()
    {
        this.State = this.State.Publish();
    }
}