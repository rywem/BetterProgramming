using System;
using System.Collections.Generic;
using static System.Console;


namespace DesignPatterns.Factories
{
    public interface IHotDrink
    {
        void Consume();
    }
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }

    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            WriteLine("This coffee is fantastic");
        }
    }

    public interface IHotDrinkFactory 
    {
        IHotDrink Prepare(int amount);
    }
    public class TeaFactory : IHotDrinkFactory 
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine($"Put in a tea bag, boil water, {amount} oz, add lemon, enjoy!");
            return new Tea();
        }
    }
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine($"Grind beans, boil water, pour {amount} oz, add cream and sugar");
            return new Coffee();
        }
    }

    public class HotDrinkMachine
    {
        private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();
        //use reflection instead of an enum
        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                //check if this type is a IHotDrinkFactory
                if(typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    factories.Add(System.Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)
                    ));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks");
            for (int index = 0; index < factories.Count; index++)
            {
                var tup = factories[index];
                Console.WriteLine($"{index}: {tup.Item1}");
            }

            while(true)
            {
                Console.WriteLine("Select an input");
                var input = Console.ReadLine();

                //int selection;
                if(!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int selection))
                {
                    if(selection > 0 && selection < factories.Count)
                    {
                        //return factories[selection].Item2;
                        Console.WriteLine("Specify amount:");

                        input = ReadLine();
                        if(!string.IsNullOrWhiteSpace(input) 
                           && int.TryParse(input, out int amount) 
                           && amount > 0)
                        {
                            return factories[selection].Item2.Prepare(amount);
                        }
                    }
                }
                Console.WriteLine("Incorrect selection, please try again.");
            }
        }
    }
    public class AbstractFactory
    {
        public void Run()
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
