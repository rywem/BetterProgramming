using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MasterTheGarbageCollector
{
    public class Finalizers
    {
        // Objects with finalizers will always span generation 0 and 1
        public void Run()
        {
            int count = 0;
            while ( !Console.KeyAvailable )
            {
                new MyObject(count++);
            }            
            Console.WriteLine("Terminating process...");
        }
    }

    public class MyObject
    {
        private int _index = 0;
        public MyObject(int index)
        {
            this._index = index;
            Console.WriteLine("Constructed object {0} in gen {1}", _index, GC.GetGeneration(this));
        }

        ~MyObject()
        {
            // never use a referenced object in finalizer because the reference might already be finalized
            Thread.Sleep(5);
            Console.WriteLine("Constructed object {0} in gen {1}", _index, GC.GetGeneration(this));
        }
    }
}
