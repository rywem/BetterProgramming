using System;

namespace Autofac_Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// non-DI implementation
        /// </summary>
        public interface ILog
        {
            void Write(string message);
        }

        public class ConsoleLog : ILog
        {
            public void Write(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class Engine
        {
            private ILog log;
            private int id;
            public Engine(ILog log)
            {
                this.log = log;
                this.id = new Random().Next();
            }
        }

        public class Car
        {
            private Engine engine;
            private ILog log;

            public Car(Engine engine, ILog log)
            {
                this.engine = engine;
                this.log = log;
            }
        }
    }
}
