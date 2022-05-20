using ProxyBaseExample;


// Load only Push notification Service
var serviceManager = new ServiceManager();
string[] allServices = {"PushNotification", "Email", "SMS"};

foreach (var service in allServices)
{
    serviceManager.AddService(new LogServiceProxy(service));
}

serviceManager.Operate("PushNotification");




Console.WriteLine("-----------------------");


// Load all services and operate only push notification
var secondServiceManager = new ServiceManager();
foreach (var service in allServices)
{
    secondServiceManager.AddService(new Service(service));
}

secondServiceManager.Operate("PushNotification");