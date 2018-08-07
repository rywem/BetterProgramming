using System;

namespace MasterUnitTesting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LearnFuncsActionsPreds.Runner runner = new LearnFuncsActionsPreds.Runner();
            // runner.SimpleAnonymous();
            // runner.FuncExample_WithParams();
            // runner.ActionExample_Without_Params();
            // runner.FuncExample_Without_Params();
            //runner.Func_Anonymous_Simple();
            try
            {
                #region "basic examples"
                // UnitTestsLibrary.NunitExamples libclass = new UnitTestsLibrary.NunitExamples();
                // libclass.FailExample();
                // libclass.AssertExample();
                // libclass.Warnings();
                #endregion

                //MasterUnitTestLibrary.UnitTests.BankAccountTests accountTests = new MasterUnitTestLibrary.UnitTests.BankAccountTests();
                //accountTests.BankAccountShouldThrowOnNonPositiveDeposit();
                //accountTests.BankAccountShouldIncreaseOnPositiveDeposit();                
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());                
            }
        }
    }
}
