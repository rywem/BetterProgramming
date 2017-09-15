using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    /// <summary>
    /// C# Anonymous MEthods vs Lambda Expressions
    /// Tutorial: https://www.youtube.com/watch?v=DdmTWturP3Y&index=9&list=PLAE7FECFFFCBE1A54
    /// </summary>
    public class AnonMethodsVsLambdas
    {
        public void Run()
        {

            Console.WriteLine("Lambda expressions");
            Func<int, bool> func = i => i > 5;
            Console.WriteLine(func(2));
            Console.WriteLine(func(45));
            Console.WriteLine("Anonymous Methods");
        }

        static bool rere (int i)
        {
            return i > 5;
        }
    }
}
