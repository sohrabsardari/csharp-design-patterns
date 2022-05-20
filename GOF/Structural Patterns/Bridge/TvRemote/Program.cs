using TvRemote;

var remoteControl = new RemoteControl(new Sony());
remoteControl.TurnOn();
remoteControl.TurnOff();


var secondRemoteControl = new AdvanceRemoteControl(new Sony());
secondRemoteControl.TurnOn();
secondRemoteControl.TurnOff();
secondRemoteControl.SetChannel(5);


var thirdRemoteControl = new RemoteControl(new Lg());
thirdRemoteControl.TurnOn();
thirdRemoteControl.TurnOff();
