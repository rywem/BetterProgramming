using System;

namespace MasterUnitTesting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                UnitTestsLibrary.NunitExamples libclass = new UnitTestsLibrary.NunitExamples();
                libclass.FailExample();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());                
            }
        }
    }
}
