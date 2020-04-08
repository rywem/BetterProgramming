using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    /// <summary>
    /// C# Delegate chaining and exceptions
    /// Video: https://www.youtube.com/watch?v=uds-JicniII&list=PLAE7FECFFFCBE1A54&index=8
    /// </summary>
    public class DelChainException
    {
        public void Run()
        {
            //How to fix:
            //Action del = Moo + BeNaughty + Goo;
            //Action del = new Action(Moo) + BeNaughty + Goo;
            //or
            Action del = (Action)Moo + BeNaughty + Goo;

            foreach (Action a in del.GetInvocationList())
            {
                try
                {
                    a();
                }
                catch(Exception e)
                {
                    Console.WriteLine("error" + e.Message);
                }
            }
            //del();

        }

        void Moo() { Console.WriteLine("Moo()"); }
        void BeNaughty()  { throw new Exception(); }
        void Goo()  { Console.WriteLine("Goo()"); }
    }
}
