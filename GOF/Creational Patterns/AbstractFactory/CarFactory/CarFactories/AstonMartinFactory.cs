using CarFactory.Cars;

namespace CarFactory.CarFactories;

public class AstonMartinFactory :CarFactory
{
    public override ISportCar CreateSportCar()
    {
        return new AstonMartinDBS();
    }

    public override IMuscleCar CreateMuscleCar()
    {
        return new AstonMartinV12Vantage();
    }
}