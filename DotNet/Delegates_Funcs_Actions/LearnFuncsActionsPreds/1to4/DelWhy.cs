using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{

    /// <summary>
    /// Video tutorials on this class file:    
    /// 3. https://www.youtube.com/watch?v=rxLNJ8jCN1c
    /// </summary>
    public class DelWhy
    {

        public delegate bool MyDele(int n);

        /// <summary>
        /// Delegates allow us to pass reference to code as a parameter. 
        /// </summary>        
        int Square(int x)
        {
            return x * x;
        }

        public static IEnumerable<int> GetNumbers(IEnumerable<int> numbers, MyDele gauntlet)
        {
            foreach (int num in numbers)
            {
                if (gauntlet(num))
                    yield return num;
            }
        }
        static bool LessThanFive(int n ) { return n < 5; }
        static bool LessThanTen(int n) { return n < 10; }
        static bool GreaterThanThirteen(int n) { return n > 13; }
        public void Run()
        {
            IEnumerable<int> result = GetNumbers(new[] { 5, 3, 7, 3, 8, 4, 12, 9, 45, 1, 0, 12, 78, }, x => x > 5);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
