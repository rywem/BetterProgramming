using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTreeConsole
{
    /// <summary>
    /// https://dotnetfiddle.net/wQMkyd
    /// </summary>
    public class ToUpperVisitor : ExpressionVisitor
    {
        [return: NotNullIfNotNull("node")]
        public override Expression? Visit(Expression? node)
        {
            if(node == null)
                throw new ArgumentNullException(nameof(node));

            if(node.NodeType == ExpressionType.Parameter)
                return base.Visit(node);

            if(node.Type == typeof(string))
            {
                var toUpper = typeof(string).GetMethod("ToUpper", Type.EmptyTypes);
                var methodCallExpression = Expression.Call(node, toUpper);
                return methodCallExpression;
            }

            return base.Visit(node);
        }
    }
}
