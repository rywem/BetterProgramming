using System;

namespace MasterUnitTesting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LearnFuncsActionsPreds.Runner runner = new LearnFuncsActionsPreds.Runner();
            try
            {
                UnitTestsLibrary.NunitExamples libclass = new UnitTestsLibrary.NunitExamples();
                //libclass.FailExample();
                //libclass.AssertExample();
                libclass.Warnings();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());                
            }
        }
    }
}
