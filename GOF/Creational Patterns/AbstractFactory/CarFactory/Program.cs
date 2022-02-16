// See https://aka.ms/new-console-template for more information

using CarFactory.CarFactories;

var ford = new FordFactory();
var fordMuscleCar = ford.CreateMuscleCar();
var astonMartin = new AstonMartinFactory();
var astonMartinSportCar = astonMartin.CreateSportCar();
Console.WriteLine(fordMuscleCar.SpinningRace(astonMartinSportCar));
Console.WriteLine(astonMartinSportCar.OneMileRace(fordMuscleCar));