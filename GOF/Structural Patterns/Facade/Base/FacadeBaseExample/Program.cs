using FacadeBaseExample;

var subsystem = new Subsytem();
var subsystem2 = new Subsytem2();
var facade = new Facade(subsystem, subsystem2);


var operatedData = facade.Operate("Some data");


Console.WriteLine(operatedData);
