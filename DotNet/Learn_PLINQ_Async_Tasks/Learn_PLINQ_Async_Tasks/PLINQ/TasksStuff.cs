using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PLINQ_Async_Tasks.PLINQ
{
    public class TasksStuff
    {
        public void SimpleReturnDataTask()
        {
            var task = Task<string>.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(2000);
                return "Ryan";
            });

            Console.Write("Name... ");
            Console.Write(task.Result);
        }

        public void VoidTask()
        {
            var task = Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Returned void task");

            });

            task.Wait();



        }

    }
}
