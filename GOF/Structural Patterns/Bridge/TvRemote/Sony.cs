namespace TvRemote;

public class Sony: IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Sony: Turn on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Sony: turn off");
    }

    public void SetChannel(int number)
    {
        Console.WriteLine("Sony: Set channel");
    }
}