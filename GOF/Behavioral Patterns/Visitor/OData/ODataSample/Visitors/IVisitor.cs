using ODataSample.Expressions;

namespace ODataSample.Visitors;

public interface IVisitor
{
    void Visit(AndExpression expression);
    void Visit(OrExpression expression);
    void Visit(ContainsExpression expression);
    void Visit(EqualExpression expression);
}