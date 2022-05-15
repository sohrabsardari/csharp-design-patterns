using DecoratorBaseExample;

var decorator = new DecoratorA(new DecoratorB(new DecoratorA(new ConcreteComponent())));

Console.WriteLine(decorator.Operate());