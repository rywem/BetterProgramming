using Autofac;
using System;

namespace Autofac_Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLog>().As<ILog>(); // someone asks for an ILog, give them a ConsoleLog
            builder.RegisterType<Engine>();
            builder.RegisterType<Car>();
            //now that we've registered the components with the builder, the builder can be used to construct the actual container
            IContainer container = builder.Build();
            var car = container.Resolve<Car>(); // this gets us a Car object, same as  "new"            
            car.Go();
        }

        /// <summary>
        /// the pre-autofac main method
        /// </summary>
        /// <returns></returns>
        public static void Main_Old()
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
