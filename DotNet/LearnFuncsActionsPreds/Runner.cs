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
        public void SimpleAnonymous()
        {
            //takes no parameters
            Action actionWithoutParameter = new Action(() =>
            {
                Console.WriteLine("hello from anon1");
            });
            actionWithoutParameter();

            Action<int> actionWithParameter = m =>
            {
                Console.WriteLine("hello from anon3: " + m);
            };
            actionWithParameter(4);
        }

        public void AnonFunctionParams()
        {
            int a = 1;
            int b = 3;
            int c = 0;
            Func<int, int, int> myFunc = (x, y) =>  x + y;
            Console.WriteLine(myFunc.Invoke(a, b));
        }

        public void CombinatorialVoidAsAnonymous()
        {
            Action action = new Action(() => 
            {
                Console.WriteLine("hello from anon1");
            });   
            Action p = () =>
            {
                Console.WriteLine("hello from anon2");
            };
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
