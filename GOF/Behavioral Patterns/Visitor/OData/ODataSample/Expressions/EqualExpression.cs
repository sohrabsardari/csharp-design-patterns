using ODataSample.Visitors;

namespace ODataSample.Expressions;

public class EqualExpression : FilterExpression
{
    public string Field { get; }
    public int Value { get; set; }

    public EqualExpression(string field, int value)
    {
        Field = field;
        Value = value;
    }

    public override void AcceptVisitor(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}