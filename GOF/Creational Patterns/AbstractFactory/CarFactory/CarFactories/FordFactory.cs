using CarFactory.Cars;

namespace CarFactory.CarFactories;

public class FordFactory : CarFactory
{
    public override ISportCar CreateSportCar()
    {
        return new FordGT();
    }

    public override IMuscleCar CreateMuscleCar()
    {
        return new FordMustang();
    }
}