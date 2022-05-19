
namespace ObjectAdapterBaseExample;

public class Adapter: ITarget
{
    private Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string GetRequest()
    {
        return _adaptee.GetSomeRequest();
    }
}