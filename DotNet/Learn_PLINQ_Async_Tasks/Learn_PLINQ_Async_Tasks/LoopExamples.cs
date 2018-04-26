using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PLINQ_Async_Tasks
{
    public class LoopExamples
    {
        /// <summary>
        /// https://blogs.msdn.microsoft.com/pfxteam/2009/08/12/implementing-parallel-while-with-parallel-foreach/
        /// </summary>
        public void ParallelWhile()
        {
            //While loop is not provided out of the box.

            //the signature: 
            //public static void While(ParallelOptions parallelOptions, Func< bool > condition, Action body);
            

        }   
        

        public void ParallelFor()
        {
            Parallel.For(0, 1000, i =>
            {
                //double d = i / 1000.0;
                Process(i);
            });
            Console.ReadLine();
        }

        private void Process(double i)
        {
            Console.WriteLine(i);
        }
        private void Process(int i)
        {
            Console.WriteLine(i);
        }
        public static void While(ParallelOptions parallelOptions, Func<bool> condition, Action body)
        {

        }
        //public static IEnumerable<bool> IterateUntilFalse(Func<bool> condition)
        //{

        //}
    }


    public class FuncReminder
    {
        //public class MyFunc(){

    }
}
