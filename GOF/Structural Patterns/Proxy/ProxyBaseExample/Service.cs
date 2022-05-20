namespace ProxyBaseExample;

public class Service:IService
{
    private string _serviceName;

    public Service(string serviceName)
    {
        _serviceName = serviceName;
        Load();
    }

    private void Load()
    {
        Console.WriteLine($"Load {_serviceName}");
    }

    public string GetServiceName()
    {
        return this._serviceName;
    }

    public void Operation()
    {
        Console.WriteLine($"Do {_serviceName}");
    }
}