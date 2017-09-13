using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{

    /// <summary>
    /// Functions and Actions
    /// Video: https://www.youtube.com/watch?v=SuwUZjQdUHQ&list=PLAE7FECFFFCBE1A54&index=7
    /// </summary>
    public class FuncsActs
    {

        public void Run()
        {
            Func<int> d = ReturnFive;
            d += ReturnTen;
            d += ReturnThree;
            //int value = d();

            Func<int, bool> f = TakeAnIntReturnBool;
            f(3);
            Func<int, string, bool> fis = IntStringReturnBool;
            fis(1, "string");
            Action<int> act = TryAction;
            act(3);
            foreach (var item in GetAllReturnValues(d))
            {
                Console.WriteLine(item);
            }
        }

        public void TryAction(int vv)
        {
            Console.WriteLine("Action");
        }

        public bool IntStringReturnBool(int val, string sw)
        {
            if (val == 1)
            {
                return true;
            }
            if (!string.IsNullOrEmpty(sw))
                return false;

            return true;
        }
        public bool TakeAnIntReturnBool(int val)
        {
            return val == 1;
        }

        IEnumerable<TArg> GetAllReturnValues<TArg>(Func<TArg> d)
        {
            
            foreach (Func<TArg> del in d.GetInvocationList())
                yield return del();                        
        }

        int ReturnFive()
        {
            return 5;
        }

        int ReturnTen()
        {
            return 10;
        }
        int ReturnThree()
        {
            return 3;
        }
    }
}
