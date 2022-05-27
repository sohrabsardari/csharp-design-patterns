namespace FacadeBaseExample;

public  class Subsytem2
{
    public string Persist(string data, string connection)
    {
        return $"{data} in connection {connection} persisted";
    }
}