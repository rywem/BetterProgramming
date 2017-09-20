using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    /// <summary>
    /// C# Closures
    /// Videos: https://www.youtube.com/watch?v=gBO_4BMbsO8&index=10&list=PLAE7FECFFFCBE1A54
    /// </summary>
    public class Closures
    {
        public void Run()
        {
            int i = 0; //Note i's scope is outside of the action's lambda expression
            Action action = () => i++;  //() = explicitly states there are no arguments
            action();            
            Console.WriteLine(i);

            Action newAction = GiveMeAction();
            newAction(); newAction();
            Console.WriteLine(i);
        }

        Action GiveMeAction()
        {
            int i = 0; //i's scope persists to the additional calls to this method.
            return () => i++;
        }
    }
}
