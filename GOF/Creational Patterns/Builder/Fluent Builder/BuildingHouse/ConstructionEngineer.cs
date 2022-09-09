namespace BuildingHouse;

public class ConstructionEngineer
{
    private readonly IHouseBuilder _houseBuilder;

    public ConstructionEngineer(IHouseBuilder houseBuilder)
    {
        _houseBuilder = houseBuilder;
    }

    public House ConstructHouse()
    {
        return this._houseBuilder
            .BuildFoundation()
            .BuildStructure()
            .BuildRoof()
            .PaintHouse()
            .Construct();
    }
}