namespace FacadeBaseExample;

public class Facade
{
    private Subsytem _subsytem;
    private Subsytem2 _subsytem2;

    public Facade(Subsytem subsytem, Subsytem2 subsytem2)
    {
        _subsytem = subsytem;
        _subsytem2 = subsytem2;
    }

    public string Operate(string data)
    {
        var connection = _subsytem.CreateConnection();

        var persist = _subsytem2.Persist(data, connection);

        _subsytem.CloseConnection();

        return persist;
    }
}

public  class Subsytem2
{
    public string Persist(string data, string connection)
    {
        return $"{data} in connection {connection} persisted";
    }
}