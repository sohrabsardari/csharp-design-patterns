namespace BuildingHouse;

public interface IHouseBuilder
{
    IHouseBuilder BuildFoundation();
    IHouseBuilder BuildStructure();
    IHouseBuilder BuildRoof();
    IHouseBuilder PaintHouse();
    House Construct();

}