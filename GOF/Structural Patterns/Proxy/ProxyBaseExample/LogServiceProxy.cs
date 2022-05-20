namespace ProxyBaseExample;

public class LogServiceProxy: IService
{
    private string _serviceName;
    private Service _service;

    public LogServiceProxy(string serviceName)
    {
        _serviceName = serviceName;
    }

    public string GetServiceName()
    {
        return this._serviceName;
    }

    public void Operation()
    {
        Console.WriteLine("Log the operation");
        if (_service is null)
        {
            _service = new Service(_serviceName);
        }
        _service.Operation();
    }
}