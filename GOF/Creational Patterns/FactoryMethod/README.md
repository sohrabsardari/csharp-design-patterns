# Factory Method Pattern

## Summary

|     Title      |  Category  |     Tag      |
| :------------: | :--------: | :----------: |
| Factory Method | Creational | Gang of Four |

Factory Method is a **Class Creational** Pattern

## Intent

Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.  

## Also known as

Virtual Constructor

## Diagrams

![image](https://user-images.githubusercontent.com/14781288/222534850-b8d71049-4177-4640-a495-7b76ec1a5bad.png)

## Real world example

### Traveling

Let's say you want to travel to a certain place and you have several options for doing so. The first option is travel on airways and the others are waterways, railways etc. The company will give you multiple options for each type of transportation, for example, a ship for waterways or a jet for airways. Factory method(Trip) lets subclass(Waterway Trip) decide which class to instantiate(Ship)!



```c#
public abstract class Trip
{
    public abstract ITransportation Travel(TravelType travelType);
}
public class WaterwayTrip : Trip
{
    public override ITransportation Travel(TravelType travelType)
    {
        return new Ship(travelType);
    }
}
public class AirwayTrip : Trip
{
    public override ITransportation Travel(TravelType travelType)
    {
        return new Jet(travelType);
    }
}

public enum TravelType
{
    Economy,
    Vip
}
```

```c#
public interface ITransportation
{
}

public class Ship : ITransportation
{
    public TravelType TravelType { get; private set; }

    public Ship(TravelType travelType)
    {
        TravelType = travelType;
    }
}

public class Jet : ITransportation
{
    public TravelType TravelType { get; private set; }

    public Jet(TravelType travelType)
    {
        TravelType = travelType;
    }
}
```

```c#
var trip = new AirwayTrip();

//Vip Jet
var transportation = trip.GetTransportation(TravelType.Vip);
```


## Applicability

There are multiple reason to use Factory method and most usage of it is to create a class that you want set an extensibility point (or hook) on it. You can also use it when you have a class that cannot anticipate the class of objects it must create.

## Credits

- Design Patterns: Elements of Reusable Object-Oriented Software
