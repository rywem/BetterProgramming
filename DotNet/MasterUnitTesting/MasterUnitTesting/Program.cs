using System;

namespace MasterUnitTesting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LearnFuncsActionsPreds.Runner runner = new LearnFuncsActionsPreds.Runner();
            runner.SimpleAnonymous();
            try
            {
                #region "basic examples"
                //UnitTestsLibrary.NunitExamples libclass = new UnitTestsLibrary.NunitExamples();
                //libclass.FailExample();
                //libclass.AssertExample();
                //libclass.Warnings();
                #endregion

                UnitTestsLibrary.BankAccountTests accountTests = new UnitTestsLibrary.BankAccountTests();
                accountTests.BankAccountShouldThrowOnNonPositiveDeposit();
                //accountTests.BankAccountShouldIncreaseOnPositiveDeposit();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());                
            }
        }
    }
}
