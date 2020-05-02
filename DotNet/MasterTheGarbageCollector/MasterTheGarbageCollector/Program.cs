using System;

namespace MasterTheGarbageCollector
{
    class Program
    {
        static void Main( string[] args )
        {
            // new keyword creates an object on the heap

            //Finalizers finalizer = new Finalizers();
            //finalizer.Run();

            DisposePattern.Run();

            Console.ReadLine();
        }


    }
}
