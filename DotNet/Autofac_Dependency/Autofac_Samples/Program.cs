using Autofac;
using Autofac.Core;
using Autofac.Features.OwnedInstances;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Autofac_Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //controlled instantiation
            //Owned<T>
            
            //https://www.udemy.com/di-ioc-dotnet/learn/v4/t/lecture/6560422?start=0
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLog>();
            builder.RegisterType<OwnedReporting>();
            using (var c = builder.Build())
            {
                c.Resolve<OwnedReporting>().ReportOnce();
                Console.WriteLine("done reporting");
            }
        }
        #region Implicit relationship
        static void Main_delayed_construction()
        {
            new Lazy<ConsoleLog>(() => new ConsoleLog());
            //https://www.udemy.com/di-ioc-dotnet/learn/v4/t/lecture/6560422?start=0
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLog>();
            builder.RegisterType<Reporting>();
            using (var c = builder.Build())
            {
                c.Resolve<Reporting>().Report();
            }
        }

        static void Main_Controlled_Instantiation(string[] args)
        {
            //controlled instantiation
            //https://www.udemy.com/di-ioc-dotnet/learn/v4/t/lecture/6560422?start=0
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLog>();
            builder.RegisterType<OwnedReporting>();
            using (var c = builder.Build())
            {
                c.Resolve<OwnedReporting>().ReportOnce();
                Console.WriteLine("done reporting");
            }
        }
        #endregion

        #region registration concepts
        static void Main_Scanning_for_Modules()
        {
            //https://www.udemy.com/di-ioc-dotnet/learn/v4/t/lecture/6456212?start=0
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(typeof(Program).Assembly);
            //or
            builder.RegisterAssemblyModules<ParentChildModule>(typeof(Program).Assembly);
            var container = builder.Build();
            Console.WriteLine(container.Resolve<Child>().Parent);
        }
        static void Main_Registering_Assemblies()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Log")) //register's assemblies ending with log
                .Except<SMSLog>()   //excludes SMSLog
                .Except<ConsoleLog>(c => c.As<ILog>().SingleInstance())
                .AsSelf();

            builder.RegisterAssemblyTypes(assembly)
                .Except<SMSLog>()
                .Where(t => t.Name.EndsWith("Log"))
                .As(t => t.GetInterfaces()[0]);  //get the first interface of the type
            Console.ReadLine();
        }
        static void Main_Parameter_AtResolution()
        {
            var builder = new ContainerBuilder();            
            Random random = new Random();
            builder.Register((c, p) => new SMSLog(p.Named<string>("phoneNumber"))).As<ILog>();//do everything at resolution time
            Console.WriteLine("building");
            var container = builder.Build();
            Console.WriteLine("resolving");
            var log = container.Resolve<ILog>(new NamedParameter("phoneNumber", random.Next().ToString()));

            log.Write("Testing");

            Console.ReadLine();
        }
        static void Main_Parameters()
        {
            var builder = new ContainerBuilder();
            //named parameter
            //builder.RegisterType<SMSLog>().As<ILog>().WithParameter("number", "123-456-7890");
            //typed parameter
            //builder.RegisterType<SMSLog>().As<ILog>().WithParameter(new TypedParameter(typeof(string), "123-456-7890"));
            //resolved parameter
            builder.RegisterType<SMSLog>().As<ILog>().WithParameter(
                new ResolvedParameter(
                    //predicate
                    (propertyInfo, iComponentContext) => propertyInfo.ParameterType == typeof(string) && propertyInfo.Name == "number",
                    //value accessor
                    (propertyInfo, iComponentContext) => "123-456-7890"
                    )
                );

            var container = builder.Build();
            var log = container.Resolve<ILog>();
            log.Write("test message");
            Console.ReadLine();
        }

        static void Main_Specifying_Generics()
        {
            var builder = new ContainerBuilder();
            //suppose that if an IList<T> is requested, they get a "List<T>

            builder.RegisterGeneric(typeof(List<>)).As(typeof(IList<>));

            IContainer container = builder.Build();

            var myList = container.Resolve<IList<int>>();
            Console.WriteLine(myList.GetType());
            //var car = container.Resolve<Car>(); // this gets us a Car object, same as  "new"            
            //car.Go();
            Console.ReadLine();
        }
        static void Main_UnitTesting_Setup(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLog>().As<ILog>();
            builder.Register((IComponentContext c)
                             => new Engine(c.Resolve<ILog>(), 121));
            //builder.RegisterType<Engine>();
            builder.RegisterType<Car>()
                   .UsingConstructor(typeof(Engine));
            //now that we've registered the components with the builder, the builder can be used to construct the actual container
            IContainer container = builder.Build();
            var car = container.Resolve<Car>(); // this gets us a Car object, same as  "new"            
            car.Go();
            Console.ReadLine();
        }
        static void Main_RegisterTypes()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmailLog>()
                   .As<ILog>();
            builder.RegisterType<ConsoleLog>()
                   .As<ILog>()
                   .As<IConsole>()
                   .PreserveExistingDefaults(); // something asks for an ILog, give them a ConsoleLog
            //var log = new ConsoleLog();
            //builder.RegisterInstance(log).As<ILog>();
            builder.RegisterType<Engine>();
            builder.RegisterType<Car>()
                   .UsingConstructor(typeof(Engine));
            //now that we've registered the components with the builder, the builder can be used to construct the actual container
            IContainer container = builder.Build();
            var car = container.Resolve<Car>(); // this gets us a Car object, same as  "new"            
            car.Go();
            Console.ReadLine();
        }
        static void Main_Instance_Example()
        {
            var builder = new ContainerBuilder();
            var log = new ConsoleLog();
            builder.RegisterInstance(log).As<ILog>();
            builder.RegisterType<Engine>();
            builder.RegisterType<Car>()
                   .UsingConstructor(typeof(Engine));
            //now that we've registered the components with the builder, the builder can be used to construct the actual container
            IContainer container = builder.Build();
            var car = container.Resolve<Car>(); // this gets us a Car object, same as  "new"            
            car.Go();
            Console.ReadLine();
        }
        #endregion
        /// <summary>
        /// the pre-autofac main method
        /// </summary>
        /// <returns></returns>
        public static void Main_Without_Containers()
        {
            var log = new ConsoleLog();
            var engine = new Engine(log);
            var car = new Car(engine, log);
            car.Go();
        }
        /// <summary>
        /// non-DI implementation
        /// </summary>
    }
    public interface ILog : IDisposable
    {
        void Write(string message);
    }
    public interface IConsole
    {

    }

    public class ConsoleLog : ILog, IConsole
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void Dispose()
        {
            Console.WriteLine("Console logger no longer required");
        }
    }

    public class EmailLog : ILog
    {
        private const string adminEmail = "admin@foo.com";

        public void Write(string message)
        {
            Console.WriteLine($"Email sent to {adminEmail} : {message}");
        }
        public void Dispose()
        {
            Console.WriteLine("Console logger no longer required");
        }
    }

    public class SMSLog : ILog
    {
        string phoneNumber;

        public SMSLog(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public void Write(string message)
        {
            Console.WriteLine($"SMS sent to {phoneNumber} : {message}");
        }
        public void Dispose()
        {
            Console.WriteLine("Console logger no longer required");
        }
    }

    public class OwnedReporting
    {
        Owned<ConsoleLog> log;

        public OwnedReporting(Owned<ConsoleLog> log)
        {
            if(log == null)
            {
                throw new ArgumentNullException(paramName: nameof(log));
            }
            this.log = log;
            Console.WriteLine("Reporting initialized");
        }

        public void ReportOnce()
        {
            log.Value.Write("Log started");
            log.Dispose();
        }
    }
    public class Reporting
    {
        Lazy<ConsoleLog> log;
        public Reporting(Lazy<ConsoleLog> log)
        {
            if (log == null)
            {
                throw new ArgumentNullException(paramName: nameof(log));
            }
            this.log = log;
            Console.WriteLine("Reporting component created");
        }
        public void Report()
        {
            log.Value.Write("Log started");
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
        public Engine(ILog log, int Id)
        {
            this.log = log;
            this.id = Id;
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

        public Car(Engine engine)
        {
            this.engine = engine;
            this.log = new EmailLog();
        }
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
    public class Parent
    {
        public override string ToString()
        {
            return "this is the parent";
        }
    }

    public class Child
    {
        public string Name { get; set; }
        public Parent Parent { get; set; }

        public void SetParent(Parent parent)
        {
            Parent = parent;
        }
    }

    public class ParentChildModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder);)
            builder.RegisterType<Parent>();
            builder.Register(c => new Child() { Parent = c.Resolve<Parent>() });
        }
    }
}
