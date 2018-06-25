using System;

namespace MasterUnitTesting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LearnFuncsActionsPreds.Runner runner = new LearnFuncsActionsPreds.Runner();
            runner.FuncExample(4);
            runner.ActionExample(7);
            try
            {
                UnitTestsLibrary.NunitExamples libclass = new UnitTestsLibrary.NunitExamples();
                //libclass.FailExample();
                libclass.AssertExample();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());                
            }
        }
    }
}
