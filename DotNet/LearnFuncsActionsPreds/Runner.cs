using System;
using System.Collections.Generic;

namespace LearnFuncsActionsPreds
{
    delegate T MeDelegate<T>();
    public class Runner
    {
        public void ActionRunner(Action action)
        {
            
        }

        public void DelegateRunner(Delegate d)
        {
            
        }

        public void FuncExample(int x) 
        {
            Func<int, long> result = s => Combinatorial(s);

            Console.WriteLine(result(x));
        }
        public void ActionExample(int x)
        {
            Action<int> result = a => CombinatorialVoid(a);
            result(x);
        }

        public void CombinatorialVoid(int p)
        {
            long output = 0;
            for (int i = 0; i <= p; i++)
            {
                output += (long)i;
            }
            Console.WriteLine(output);
        }

        public long Combinatorial(int p)
        {
            long output = 0;
            for (int i = 0; i <= p; i++)
            {
                output += (long)i;
            }
            return output;
        }
    }
}
