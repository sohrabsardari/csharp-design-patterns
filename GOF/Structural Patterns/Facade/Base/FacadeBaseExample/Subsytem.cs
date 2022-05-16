namespace FacadeBaseExample;

public  class Subsytem
{
    public string CreateConnection()
    {
        return "Connection";
    }

    public void CloseConnection()
    {
        Console.WriteLine("Closing Connection");
    }
}