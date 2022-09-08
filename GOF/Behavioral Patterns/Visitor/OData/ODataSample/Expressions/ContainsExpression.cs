using ODataSample.Visitors;

namespace ODataSample.Expressions;

public class ContainsExpression : FilterExpression
{
    public string Field { get; }
    public string Value { get; }

    public ContainsExpression(string field, string value)
    {
        Field = field;
        Value = value;
    }
    public override void AcceptVisitor(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}