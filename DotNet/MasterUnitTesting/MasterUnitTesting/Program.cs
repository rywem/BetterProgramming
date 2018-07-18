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
                #region "basic examples"
                //UnitTestsLibrary.NunitExamples libclass = new UnitTestsLibrary.NunitExamples();
                //libclass.FailExample();
                //libclass.AssertExample();
                //libclass.Warnings();
                #endregion

                UnitTestsLibrary.AccountTests accountTests = new UnitTestsLibrary.AccountTests();

                accountTests.BankAccountShouldIncreaseOnPositiveDeposit();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());                
            }
        }
    }
}
