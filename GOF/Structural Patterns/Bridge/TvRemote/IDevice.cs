namespace TvRemote;

public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int number);
}