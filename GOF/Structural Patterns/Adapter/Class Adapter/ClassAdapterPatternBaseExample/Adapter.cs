
namespace ClassAdapterPatternBaseExample;

public class Adapter: Adaptee, ITarget
{
    public string GetRequest()
    {
        return base.GetSomeRequest();
    }
}