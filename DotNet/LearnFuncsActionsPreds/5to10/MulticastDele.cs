using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    /// <summary>
    /// Multicast Delegate
    /// Video: https://www.youtube.com/watch?v=1hK6vGqaNkw&list=PLAE7FECFFFCBE1A54&index=6
    /// </summary>
    public class MulticastDele
    {
        delegate int MyDele();
        public void Run()
        {
            MyDele d = ReturnFive;
            d += ReturnTen;
            d += ReturnThree;
            //int value = d();
            List<int> ints = new List<int>();
            foreach (MyDele del in d.GetInvocationList())
            {
                ints.Add(del());
                
            }

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
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
