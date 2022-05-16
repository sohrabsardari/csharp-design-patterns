namespace CompositeBaseExample;

public abstract class Component
{
    public abstract void Operation();

    public virtual void Add(Component component)
    {
        throw new NotSupportedException();
    }

    public virtual void Remove(Component component)
    {
        throw new NotSupportedException();
    }

    public abstract bool IsComposite();
}