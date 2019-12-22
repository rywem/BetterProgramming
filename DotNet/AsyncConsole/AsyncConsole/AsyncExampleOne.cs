using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConsole
{
    public class AsyncExampleOne
    {
        public async Task DoSomethingAsync()
        {
            Console.WriteLine("Starting Async work");
            await GetStringAsync();
            
        }

        public async Task GetStringAsync()
        {
            await Task.Run(() => 
            {
                Console.WriteLine("3. Awaiting the result of GetStringAsync of Http Client...");
                System.Threading.Thread.Sleep(500);

                //From this line and below, the execution will resume once the above awaitable is done
                //using await keyword, it will do the magic of unwrapping the Task<string> into string (result variable)
                Console.WriteLine("4. The awaited task has completed. Let's get the content length...");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"5. The length of http Get for url");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"6. 454 character");
            });
        }

        public void SynchronousWork()
        {
            Console.WriteLine("1. Doing some work synchronously.");
        }


        public void DoSynchronousWorkAfterAwait()
        {
            //This is the work we can do while waiting for the awaited Async Task to complete
            Console.WriteLine("7. While waiting for the async task to finish, we can do some unrelated work...");
            for ( var i = 0; i <= 5; i++ )
            {
                for ( var j = i; j <= 5; j++ )
                {
                    Console.Write("*");
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(500);
            }
        }
    }

}
