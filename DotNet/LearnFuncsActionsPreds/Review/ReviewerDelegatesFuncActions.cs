using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds.Review
{
    //https://www.youtube.com/watch?v=SuwUZjQdUHQ&list=PLAE7FECFFFCBE1A54&index=7
    public delegate T MeDelegate<T>(); //compiler turns this into a class 
    public class ReviewerDelegatesFuncActions
    {
        public void Run()
        {
            MeDelegate<int> d = ReturnFive; //type we want... 

            d += ReturnTen;
            d += Return22;

            foreach (int i in GetAllReturnValues<int>(d)) //type we want to use..
            {
                Console.WriteLine(i);
            }
        }

        public IEnumerable<TArg> GetAllReturnValues<TArg>(MeDelegate<TArg> d)
        {
            foreach (MeDelegate<TArg> del in d.GetInvocationList())
                yield return del();
        }

        public int ReturnFive() { return 5; }
        public int ReturnTen() { return 10; }
        public int Return22() { return 22; }

    }
}
