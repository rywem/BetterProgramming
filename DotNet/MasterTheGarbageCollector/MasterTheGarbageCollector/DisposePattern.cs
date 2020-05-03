using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MasterTheGarbageCollector
{
    public class DisposePattern
    {
        public static long FinalizedObjects = 0;
        public static long TotalTime = 0;

        public static void Run()
        {
            //for ( int i = 0; i < 500000; i++ )
            //{
            //    var obj = new WithoutDispose();
            //    obj.DoWork();
            //}
            //double avgLifetime = 1.0 * TotalTime / FinalizedObjects;

            //Console.WriteLine("WithoutDispose Number of disposed finalized objects: {0}k", FinalizedObjects / 1000);
            //Console.WriteLine("WithoutDispose Average resource lifetime: {0}ms", avgLifetime);

            
            Console.WriteLine();

            for ( int i = 0; i < 500000; i++ )
            {
                using ( var obj = new WithDispose() )
                {
                    obj.DoWork();
                }
            }
            double avgLifetime2 = 1.0 * TotalTime / FinalizedObjects;
            Console.WriteLine("WithDispose Number of disposed finalized objects: {0}k", FinalizedObjects / 1000);
            Console.WriteLine("WithDispose Average resource lifetime: {0}ms", avgLifetime2);
        }

    }

    public class WithoutDispose
    {
        private Stopwatch stopwatch = null;
        public WithoutDispose()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }
        public void DoWork()
        {
            double j = 0;
            for ( int i = 0; i < 1000; i++ )
            {
                j += i * i;
            }
        }

        ~WithoutDispose()
        {
            stopwatch.Stop();
            Interlocked.Increment(ref DisposePattern.FinalizedObjects);
            Interlocked.Add(ref DisposePattern.TotalTime, stopwatch.ElapsedMilliseconds);
        }
    }

    public class WithDispose : IDisposable
    {
        private Stopwatch stopwatch = null;
        private bool disposed = false;
        public WithDispose()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }
        public void DoWork()
        {
            double j = 0;
            for ( int i = 0; i < 1000; i++ )
            {
                j += i * i;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing )
        {
            if ( !disposed )
            {
                stopwatch.Stop();
                Interlocked.Increment(ref DisposePattern.FinalizedObjects);
                Interlocked.Add(ref DisposePattern.TotalTime, stopwatch.ElapsedMilliseconds);

                if ( disposing )
                {
                    // explicitly called from user code
                    // can basically do anything
                }
                else
                {
                    // called from finaliser
                    // do not access references, run quickly etc
                }
            }
        }

        ~WithDispose()
        {
            Dispose(false);
        }
    }

}
