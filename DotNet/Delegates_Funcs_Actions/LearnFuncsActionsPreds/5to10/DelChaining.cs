using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    /// <summary>
    /// Delegate Chaining
    /// Video: https://www.youtube.com/watch?v=UZAZAV0rV8I&list=PLAE7FECFFFCBE1A54&index=5
    /// </summary>
    public class DelChaining
    {
        delegate void MyDelegate();

        public void Run()
        {
            MeDelegate d = Foo;
            //d();
            //d = Goo;
            //d();
            //d = Sue;
            //d();
            //Chain these together:
            d += Goo;
            d += Sue;
            d += Foo;
            d();
        }
        public void Foo()
        {
            Console.WriteLine("foo()");
        }
        public void Goo()
        {
            Console.WriteLine("goo()");
        }
        public void Sue()
        {
            Console.WriteLine("Sue()");
        }
    }
}
