namespace DecoratorBaseExample;

public class DecoratorB : IComponent
{
    private readonly IComponent _component;

    public DecoratorB(IComponent component)
    {
        _component = component;
    }

    public string Operate()
    {

        return $"Decorated by B {_component.Operate()}";
    }
}