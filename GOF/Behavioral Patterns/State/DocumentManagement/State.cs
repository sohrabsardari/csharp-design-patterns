public abstract class State
{
    public virtual State Render()
    {
        throw new NotSupportedException();
    }

    public virtual State Publish()
    {
        throw new NotSupportedException();
    }
}