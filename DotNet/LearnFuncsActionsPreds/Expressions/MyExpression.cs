using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace LearnFuncsActionsPreds.Expressions
{
    public class MyExpression
    {
        /// <summary>
        /// Source: https://docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression?view=netframework-4.8
        /// </summary>
        public void Run()
        {
            BlockExpression blockExpr = Expression.Block(Expression.Call(null, typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                                                                        Expression.Constant("Hello")
                                                                        ),
                                                        Expression.Call(null, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                                                                        Expression.Constant("World")
                                                                        ),
                                                        Expression.Constant(42)
                                                        );

            Console.WriteLine("The result of executing the expression tree:");
            // The following statement first creates an expression tree,
            // then compiles it, and then executes it.           
            var result = Expression.Lambda<Func<int>>(blockExpr).Compile()();

            // Print out the expressions from the block expression.
            Console.WriteLine("The expressions from the block expression:");
            foreach (var expr in blockExpr.Expressions)
            {
                Console.WriteLine(expr.ToString());
            }

            // Print out the result of the tree execution.
            Console.WriteLine("The return value of the block expression:");
            Console.WriteLine(result);

        }
    }
}
