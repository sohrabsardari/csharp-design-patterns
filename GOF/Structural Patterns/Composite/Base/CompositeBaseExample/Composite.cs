namespace CompositeBaseExample;

public class Composite : Component
{
    private List<Component> _components = new List<Component>();

    public void Add(Component component)
    {
        _components.Add(component);
    }

    public void Remove(Component component)
    {
        _components.Remove(component);
    }

    public Component GetChild(int number)
    {
        return _components[number];
    }

    public override void Operation()
    {
        foreach (var component in _components)
        {
            component.Operation();
        }
    }
}