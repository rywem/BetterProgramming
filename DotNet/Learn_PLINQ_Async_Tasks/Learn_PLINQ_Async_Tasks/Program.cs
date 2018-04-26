using Learn_PLINQ_Async_Tasks.PLINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PLINQ_Async_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopExamples examples = new LoopExamples();
            examples.ParallelFor();
            //TasksStuff stuff = new TasksStuff();
            //stuff.VoidTask();

            //WordReversal reverse = new WordReversal();
            //reverse.Run();

            Console.ReadLine();
        }

    }
}
