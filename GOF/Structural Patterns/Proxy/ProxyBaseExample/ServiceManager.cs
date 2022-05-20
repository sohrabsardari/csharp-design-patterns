using ProxyBaseExample;

public class ServiceManager
{
    private Dictionary<string, IService> _services = new Dictionary<string, IService>();

    public void AddService(IService service)
    {
        _services.Add(service.GetServiceName(), service);
    }

    public void Operate(string serviceName)
    {
        _services[serviceName].Operation();
    }
}