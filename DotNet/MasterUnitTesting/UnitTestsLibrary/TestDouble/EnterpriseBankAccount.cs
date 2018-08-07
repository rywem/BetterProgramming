using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsLibrary.TestDouble
{

    public class ConsoleLog : ILog
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public interface ILog
    {
        void Write(string msg);
    }
    /// <summary>
    /// https://www.udemy.com/nunit-moq/learn/v4/t/lecture/7352702?start=0
    /// </summary>
    public class EnterpriseBankAccount
    {
        public int Balance { get; set; }
        private readonly ILog log;

        public EnterpriseBankAccount(ILog log)
        {

        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
    [TestFixture]
    public class EnterpriseBankAccountTests
    {
        private EnterpriseBankAccount bankAccount;
        [Test]
        public void DepositIntegrationTest()
        {
            bankAccount = new EnterpriseBankAccount(new ConsoleLog()) { Balance = 100 };
            bankAccount.Deposit(100);
            Assert.That(bankAccount.Balance, Is.EqualTo(200));
        }
    }
}
