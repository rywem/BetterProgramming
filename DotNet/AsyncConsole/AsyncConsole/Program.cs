using System;

namespace AsyncConsole
{
    class Program
    {
        /// <summary>
        /// A project to brush up on async programming.
        /// </summary>
        /// <param name="args"></param>
        static void Main( string[] args )
        {
            AsyncExampleOne example = new AsyncExampleOne();

            example.SynchronousWork();
            var myTask = example.DoSomethingAsync();
            example.DoSynchronousWorkAfterAwait();
            myTask.Wait();
            Console.ReadLine();
        }
    }
}
