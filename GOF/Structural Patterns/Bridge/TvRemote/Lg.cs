namespace TvRemote;

public class Lg: IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("LG: Turn on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("LG: Turn off!");
    }

    public void SetChannel(int number)
    {
        Console.WriteLine("LG: Set channel!");
    }
}