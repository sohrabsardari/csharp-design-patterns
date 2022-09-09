namespace BuildingHouse;

public class IglooBuilder :IHouseBuilder
{
    private readonly House _house;

    public IglooBuilder()
    {
        _house = new House();
    }
    public IHouseBuilder BuildFoundation()
    {
        _house.SetFoundation("compressed snow");
        return this;
    }

    public IHouseBuilder BuildStructure()
    {
        _house.SetStructure("compressed snow");
        return this;
    }

    public IHouseBuilder BuildRoof()
    {
        _house.SetRoof("small blocks of compressed snow");
        return this;
    }

    public IHouseBuilder PaintHouse()
    {
        _house.SetPaintedTo(false);
        return this;
    }

    public House Construct()
    {
        return _house;
    }
}