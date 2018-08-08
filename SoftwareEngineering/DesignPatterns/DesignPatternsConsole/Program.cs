using System;

namespace DesignPatternsConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var journal = new DesignPatterns.SOLID.Journal();
            //journal.AddEntry("I wrote code today");
            //journal.AddEntry("I drank coffee today");
            //Console.WriteLine(journal);

            //var runner = new DesignPatterns.SOLID.ORunner();
            //runner.Run();
            var runner = new DesignPatterns.SOLID.LRunner();
            runner.Run();
        }
    }
}
