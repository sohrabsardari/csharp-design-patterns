using ODataSample.Visitors;

namespace ODataSample.Expressions;

public class OrExpression : FilterExpression
{
    public FilterExpression Left { get; }
    public FilterExpression Right { get; }

    public OrExpression(FilterExpression left, FilterExpression right)
    {
        Left = left;
        Right = right;
    }

    public override void AcceptVisitor(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}