using Xunit;

namespace BuildingHouse.Tests
{
    public class IglooTests
    {
        [Fact]
        public void building_an_igloo()
        {
            var iglooBuilder = new IglooBuilder();
            var constructionEngineer = new ConstructionEngineer(iglooBuilder);

            var igloo = constructionEngineer.ConstructHouse();
        }
    }
}