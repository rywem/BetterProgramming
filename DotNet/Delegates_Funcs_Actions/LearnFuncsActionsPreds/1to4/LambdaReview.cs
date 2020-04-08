using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFuncsActionsPreds
{
    /// <summary>
    /// Video tutorials on this class file:    
    /// 3. https://www.youtube.com/watch?v=KRjeu9Thp3s
    /// </summary>
    public class LambdaReview
    {
        public delegate bool MyDele(int n);    

        public static IEnumerable<int> GetNumbers(IEnumerable<int> numbers, MyDele gauntlet)
        {
            foreach (int num in numbers)
            {
                if (gauntlet(num))
                    yield return num;
            }
        }
        static bool LessThanFive(int n) { return n < 5; }
        
        public void Run()
        {
            int[] numbers = new[] { 5, 3, 7, 3, 8, 4, 12, 9, 45, 1, 0, 12, 78, };
            //Shortening this function, to a lambda:
            //  static bool LessThanFive(int n) { return n < 5; }   [original method]
            //  bool LessThanFive(int n) { return n < 5; }          (can infer its static)
            //  LessThanFive(int n) { return n < 5; }               (can infer its return type)
            //  (int n) { return n < 5; }                           (name is unnecessary so we can remove it)
            //  (n) { return n < 5; }                               (can infer n is an int because MyDele takes an int: MyDele(int n)
            //  n { return n < 5; }                                 (Paranethesis infer more than one argument, so we don't need those)
            //  n { n < 5; }                                        (The return is implied, so its unnecessary)
            //  n  n < 5;                                           (Curly's are verbose, remove those.
            //  n  n < 5                                            (Remove semicolon, its uneccessary);
            //  n  n < 5                                            (All that's really important is the argument name, and the expression return);
            //  n => n < 5                                          (Arrow points to the body of the method
            // this can now be passed into a delegate parameter as an argument

            IEnumerable<int> result = GetNumbers(numbers, n => n < 5);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
