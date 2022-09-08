using ODataSample.Visitors;

namespace ODataSample.Expressions;

public abstract class FilterExpression
{
    public abstract void AcceptVisitor(IVisitor visitor);

    public FilterExpression And(FilterExpression expression)
    {
        return new AndExpression(expression, this);
    }

    public FilterExpression Or(FilterExpression expression)
    {
        return new OrExpression(expression, this);
    }
}