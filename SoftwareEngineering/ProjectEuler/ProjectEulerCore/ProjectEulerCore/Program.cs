using ProjectEulerCore.Problems;
using System;
using System.Threading.Tasks;

namespace ProjectEulerCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                P25Fibonacci fib = new P25Fibonacci();
                var result = fib.GetFirstIndexWithLength(1000);
                Console.WriteLine("Answer: " + result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
