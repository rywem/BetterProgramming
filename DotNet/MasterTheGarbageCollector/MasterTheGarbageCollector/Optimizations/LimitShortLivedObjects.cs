using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MasterTheGarbageCollector.Optimizations
{
    /// <summary>
    /// https://www.udemy.com/course/csharp-memory-tricks-learn-how-to-master-the-garbage-collector/learn/lecture/3505474#announcements
    /// </summary>
    public class LimitShortLivedObjects
    {
        public void MemoryUseOfHeap()
        {
            StringBuilder wrong = new StringBuilder();
            StringBuilder right = new StringBuilder();
            for ( int i = 0; i < 10000; i++ )
            {
                wrong.Append(i.ToString() + "KB"); // The 2 strings on the heap with the + 
                right.Append(i.ToString()); // Difference of 40,000 less string objects on the heap
                right.Append("KB");
            }

            ArrayList bad = new ArrayList();
            List<int> good = new List<int>();

            for ( int i = 0; i < 10000; i++ )
            {
                bad.Add(i); // boxes i on the heap
                good.Add(i); // uses an internal int[], 20,000 less operations on the heap
            }
        }

        public void FineTuneLifetimeOfObjects()
        {
            // Avoid large short-lived objects
            // Avoid small long-lived objects

            // Optimizing Short-lived large objects
            //      - Object pooling: reuse existing objects

            // Optimizing object size
        }

        public void InitilizeSmallAsLarge()
        {
            // This list we need to be a large array
            ArrayList bad = new ArrayList(); // 16 kb size
            ArrayList good = new ArrayList(85190); // 85kb, initializes as large object
        }
    }
}
