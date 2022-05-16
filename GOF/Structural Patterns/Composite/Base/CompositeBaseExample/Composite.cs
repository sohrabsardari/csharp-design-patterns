namespace CompositeBaseExample;

public class Composite : Component
{
    private List<Component> _components = new List<Component>();

    public override void Add(Component component)
    {
        _components.Add(component);
    }

    public override void Remove(Component component)
    {
        _components.Remove(component);
    }

    public override bool IsComposite()
    {
        return true;
    }

    public override void Operation()
    {
        foreach (var component in _components)
        {
            component.Operation();
        }
    }
}