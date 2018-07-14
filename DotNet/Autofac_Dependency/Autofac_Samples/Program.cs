using System;

namespace Autofac_Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new ConsoleLog();
            var engine = new Engine(log);
            var car = new Car(engine, log);
            car.Go();
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

            public void Ahead(int power)
            {
                log.Write($"Engine [{id}] ahead {power}");
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

            public void Go()
            {
                engine.Ahead(100);
                log.Write("Car going forward...");
            }
        }
    }
}
