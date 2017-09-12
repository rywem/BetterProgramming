using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{

    delegate void MyDelegate(int value);

    /// <summary>
    /// Video tutorials on this class:
    /// 2: https://www.youtube.com/watch?v=N9XmnG91G5g
    /// </summary>
    public class DelTargets
    {
        public void Run()
        {
            //The method to invoke it on
            //The address of the method

            //Invoke a method on an object
            Console.WriteLine("Invoke on class object:");
            DelTargets targets = new DelTargets();
            targets.Goo(2);
            Console.WriteLine("Invoke on delegate:");
            //Invoke a method on a delegate
            MyDelegate d = Foo;
            d = targets.Goo;
            d(2);

            Console.WriteLine("delegate method: " + d.Method);
            Console.WriteLine("delegate target: " + d.Target);
        }

        void Foo(int val)
        {
            Console.WriteLine("DelTargets.Foo() Traced");
        }

        void Goo(int blah)
        {
            Console.WriteLine("DelTargets.Goo() Traced");
        }
    }
}
