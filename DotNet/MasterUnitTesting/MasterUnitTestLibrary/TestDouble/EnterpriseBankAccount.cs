using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterUnitTestLibrary.TestDouble
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
    /// Implement null pattern
    /// </summary>
    public class NullLog : ILog
    {
        public void Write(string msg)
        {
            //nothing happens
        }
    }

    /// <summary>
    /// https://www.udemy.com/nunit-moq/learn/v4/t/lecture/7352702?start=0
    /// </summary>
    public class EnterpriseBankAccount
    {
        public int Balance { get; set; }
        private readonly ILog _log;

        public EnterpriseBankAccount(ILog log)
        {
            this._log = log;
        }

        public void Deposit(int amount)
        {
            _log.Write($"depositing {amount}");
            Balance += amount;
        }
    }
    [TestFixture]
    public class EnterpriseBankAccountTests
    {
        private EnterpriseBankAccount bankAccount;
        [Test]
        public void Deposit_IntegrationTest()
        {
            //note, this is an integration test
            bankAccount = new EnterpriseBankAccount(new ConsoleLog()) { Balance = 100 };
            bankAccount.Deposit(100);
            Assert.That(bankAccount.Balance, Is.EqualTo(200));
        }

        [Test]
        public void Deposit_UnitTestWithFake()
        {
            // note, this is an unit test with a null pattern
            // this is a unit test because we've isolated the log object into a null class.
            // note, this (the null pattern) isn't scalable 
            bankAccount = new EnterpriseBankAccount(new NullLog()) { Balance = 100 };
            bankAccount.Deposit(100);
            Assert.That(bankAccount.Balance, Is.EqualTo(200));
        }
    }
}
