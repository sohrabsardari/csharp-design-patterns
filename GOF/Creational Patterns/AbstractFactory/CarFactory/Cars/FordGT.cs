namespace CarFactory.Cars;

public class FordGT : ISportCar
{
    public string OneMileRace(IMuscleCar muscleCar)
    {
        return $"I'm {this.GetType()},I can always win one mile races against {muscleCar.GetType()}";
    }
}