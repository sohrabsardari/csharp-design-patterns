namespace CarFactory.Cars;

public class FordMustang : IMuscleCar
{
    public string SpinningRace(ISportCar sportCar)
    {
        return $"HAHA. you kidding me, right? I'm {this.GetType()}, I can always win spinning races against {sportCar.GetType()}";
    }
}