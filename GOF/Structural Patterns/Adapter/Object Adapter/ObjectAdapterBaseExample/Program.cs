using ObjectAdapterBaseExample;

var adaptee = new Adaptee();
var target = new Adapter(adaptee);

Console.WriteLine(target.GetRequest());