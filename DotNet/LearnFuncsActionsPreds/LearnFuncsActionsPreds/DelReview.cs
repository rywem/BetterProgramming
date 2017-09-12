using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    delegate void MeDelegate(); //compiler turns this into a class 
    public class DelReview
    {
        /// <summary>
        /// Video tutorials:
        /// https://www.youtube.com/watch?v=UL2XHN6uJCg&list=PLAE7FECFFFCBE1A54
        /// </summary>
        public void Run()
        {
            Foo();
            MeDelegate del = new MeDelegate(Foo); // takes a method that returns void, 
            del(); // del() is equivalent too:  del.Invoke();
        }
        void Foo()
        {
            Console.WriteLine("trace foo");
        }
    }
}
