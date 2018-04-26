using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BetterTasks
{
    public class LearnCancellationTokens
    {
        private CancellationTokenSource _cancellationSource = new CancellationTokenSource();
        public void Start()
        {
            var task = Task.Factory.StartNew(() => LongRunningTask(_cancellationSource.Token));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Waiting main thread: " + i);
                Thread.Sleep(2000);
            }
            _cancellationSource.Cancel();
        }

        public Task LongRunningTask(CancellationToken cancellationToken)
        {
            //try
            //{
                int counter = 0;
                Task task = Task.Factory.StartNew(() =>
                {
                    List<int> myList = new List<int>();
                    while (cancellationToken.IsCancellationRequested == false)
                    {

                        //myList.Add(counter);
                        Console.WriteLine("Waiting task: " + counter);
                        Thread.Sleep(1000);
                        counter++;
                    }
                });
                return task;
            //}
            //catch(OperationCanceledException ex)
            //{
            //    Console.WriteLine("Hit exception in cancellation token!");
            //}
        }
    }
}
