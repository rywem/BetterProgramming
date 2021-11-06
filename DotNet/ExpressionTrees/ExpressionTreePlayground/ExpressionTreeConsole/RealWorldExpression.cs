using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace ExpressionTreeConsole
{
    /// <summary>
    /// https://www.youtube.com/watch?v=Ptnxc6tVIPE
    /// </summary>
    public class RealWorldExpression
    {
        public void Run()
        {
            Func<string, string> func = c => c.ToUpper();
            //Console.WriteLine(func("Ryan"));
            Expression<Func<string, string>> myExpression;
            //ParameterExpression, MethodCallExpression
            var constantExpression = Expression.Constant("ryan");

            //build: str => str.ToUpper()
            var parameterExpression = Expression.Parameter(typeof(string), "str");            
            var toUpper = typeof(string).GetMethod("ToUpper", Type.EmptyTypes);
            var body = Expression.Call(parameterExpression, toUpper);
            var lambda = Expression.Lambda(body, parameterExpression);
            Console.WriteLine(lambda.ToString());
            var x = lambda.Compile().DynamicInvoke("joe");
        }

        public void Run2()
        {
            Expression<Func<string, string>> spencyString = s => s + " belongs to Spencer";

            var toUpperVisitor = new ToUpperVisitor();
            var expressed = toUpperVisitor.VisitAndConvert(spencyString, null);
            Console.WriteLine(expressed.Compile().DynamicInvoke("the cheese"));
        }

        public void Run3()
        {
            var employees = new[] {
            new Employee {
                Name = "gary",
                HireDate = new DateTime(2017, 1, 1)
            },
            new Employee {
                Name = "spencer",
                HireDate = new DateTime(2014, 12, 31)
            },
            new Employee {
                Name = "michael",
                HireDate = new DateTime(2017, 1, 1)
            },
            new Employee {
                Name = "amy",
                HireDate = new DateTime(2017, 1, 1)
            },
        };

            foreach (var emp in employees.AsQueryable().OrderByPropertyOrField("Name"))
            {
                Console.WriteLine("{0} - {1:d}", emp.Name, emp.HireDate);
            }
        }
    }
}
