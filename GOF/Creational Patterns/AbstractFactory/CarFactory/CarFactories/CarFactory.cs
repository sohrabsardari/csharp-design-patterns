using CarFactory.Cars;

namespace CarFactory.CarFactories;

public abstract class CarFactory
{
    public abstract ISportCar CreateSportCar();
    public abstract IMuscleCar CreateMuscleCar();
}