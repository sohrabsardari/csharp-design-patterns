using ODataSample.Expressions;
using System.Text;

namespace ODataSample.Visitors
{
    public class ODataVisitor : IVisitor
    {
        private StringBuilder _builder = new StringBuilder();
        public void Visit(AndExpression expression)
        {
            _builder.Append("(");
            expression.Left.AcceptVisitor(this);
            _builder.Append(" and ");
            expression.Right.AcceptVisitor(this);
            _builder.Append(")");
        }

        public void Visit(OrExpression expression)
        {
            _builder.Append("(");
            expression.Left.AcceptVisitor(this);
            _builder.Append(" or ");
            expression.Right.AcceptVisitor(this);
            _builder.Append(")");
        }

        public void Visit(ContainsExpression expression)
        {
            _builder.Append($"contains({expression.Field}, '{expression.Value}')");
        }

        public void Visit(EqualExpression expression)
        {
            _builder.Append($"{expression.Field} eq {expression.Value}");
        }

        public string GetFilter()
        {
            return _builder.ToString();
        }
    }
}