using System;

namespace MasterUnitTesting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                UnitTestsLibrary.Class1 libclass = new UnitTestsLibrary.Class1();
                libclass.MyMethod();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());                
            }

        }
    }
}
