namespace DecoratorBaseExample;

public class DecoratorA : IComponent
{
    private readonly IComponent _component;

    public DecoratorA(IComponent component)
    {
        _component = component;
    }

    public string Operate()
    {

        return $"Decorated by A {_component.Operate()}";
    }
}