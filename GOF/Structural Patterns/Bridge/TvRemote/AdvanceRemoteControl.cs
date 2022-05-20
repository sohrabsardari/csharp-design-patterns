namespace TvRemote;

public class AdvanceRemoteControl: RemoteControl
{
    public AdvanceRemoteControl(IDevice device) : base(device)
    {
        
    }

    public void SetChannel(int number)
    {
        base._device.SetChannel(number);
    }
}