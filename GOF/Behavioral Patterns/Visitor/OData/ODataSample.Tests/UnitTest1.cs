using ODataSample.Expressions;
using ODataSample.Visitors;
using Xunit;

namespace ODataSample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void should_convert_filter_expressions_to_odata_filter()
        {
            var odataVisitor = new ODataVisitor();
            var filter = new ContainsExpression("Aircraft", "Airbus A330")
                .Or(new ContainsExpression("IATA", "IKA"))
                .And(new EqualExpression("LocationId", 3));

            filter.AcceptVisitor(odataVisitor);

            var actual = odataVisitor.GetFilter();
            var expected = "(LocationId eq 3 and (contains(IATA, 'IKA') or contains(Aircraft, 'Airbus A330')))";
            Assert.Equal(expected, actual);
        }
    }
}