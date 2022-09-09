namespace BuildingHouse;

public class CottageBuilder : IHouseBuilder
{
    private readonly House _house;

    public CottageBuilder()
    {
        this._house = new House();
    }

    public IHouseBuilder BuildFoundation()
    {
        _house.SetFoundation("Stone Surfaces, Wood accents");
        return this;
    }

    public IHouseBuilder BuildStructure()
    {
        _house.SetStructure("Wood material");
        return this;
    }

    public IHouseBuilder BuildRoof()
    {
        _house.SetRoof("Wood shingles");
        return this;
    }

    public IHouseBuilder PaintHouse()
    {
        _house.SetPaintedTo(true);
        return this;
    }

    public House Construct()
    {
        return _house;
    }
}