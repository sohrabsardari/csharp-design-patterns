using Xunit;

namespace BuildingHouse.Tests;

public class CottageTests
{
    [Fact]
    public void building_a_cottage()
    {
        var cottageBuilder = new CottageBuilder();
        var constructionEngineer = new ConstructionEngineer(cottageBuilder);

        var cottage = constructionEngineer.ConstructHouse();
    }
}