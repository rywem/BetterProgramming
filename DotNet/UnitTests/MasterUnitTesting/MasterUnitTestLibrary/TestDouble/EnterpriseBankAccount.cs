using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using ImpromptuInterface;
namespace MasterUnitTestLibrary.TestDouble
{

    public interface ILog
    {
        bool Write(string msg);
    }
    public class ConsoleLog : ILog
    {
        public bool Write(string msg)
        {
            Console.WriteLine(msg);
            return true;
        }
    }

    /// <summary>
    /// Implement null pattern
    /// </summary>
    public class NullLog : ILog
    {
        public bool Write(string msg)
        {
            //nothing happens
            return true;
        }
    }

    public class NullLogWithResult : ILog
    {
        private bool expectedResult;
        public NullLogWithResult(bool expectedResult)
        {
            this.expectedResult = expectedResult;
        }

        public bool Write(string msg)
        {
            return expectedResult;
        }
    }
    public class Null<T> : DynamicObject where T : class 
    {
        public static T Instance
        {
            get
            {
                return new Null<T>().ActLike<T>();
            }
        }
        public override bool TryInvokeMember(InvokeMemberBinder binder, 
            object[] args, out object result)
        {
            result = Activator.CreateInstance(typeof(T).GetMethod(binder.Name).ReturnType);

            return true;
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

        public bool Deposit(int amount)
        {
            if (_log.Write($"depositing {amount}"))
            {
                Balance += amount;
                return true;
            }
            return false;
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

        /// <summary>
        /// https://www.udemy.com/nunit-moq/learn/v4/t/lecture/6939692?start=0
        /// </summary>
        [Test]
        public void Deposit_UnitTestWithStaticFake()
        {
            // note, this is an unit test with a null pattern
            // this is a unit test because we've isolated the log object into a null class.
            // note, this (the null pattern) isn't scalable 
            bankAccount = new EnterpriseBankAccount(new NullLog()) { Balance = 100 };
            bankAccount.Deposit(100);
            Assert.That(bankAccount.Balance, Is.EqualTo(200));
        }

        /// <summary>
        /// https://www.udemy.com/nunit-moq/learn/v4/t/lecture/7352764?start=0
        /// </summary>
        [Test]
        public void Deposit_UnitTestWithDynamicFake()
        {
            var log = Null<ILog>.Instance; //creates a fake ILog object.
            bankAccount = new EnterpriseBankAccount(log) { Balance = 100 }; 
            bankAccount.Deposit(100);
            Assert.That(bankAccount.Balance, Is.EqualTo(200));
        }

        /// <summary>
        /// https://www.udemy.com/nunit-moq/learn/v4/t/lecture/7352800?start=0
        /// </summary>
        [Test]
        public void Deposit_UnitTestWithStub()
        {
            
            var log = new NullLogWithResult(true); //creates a stub ILog object.
            bankAccount = new EnterpriseBankAccount(log) { Balance = 100 };
            bankAccount.Deposit(100);
            Assert.That(bankAccount.Balance, Is.EqualTo(200));
        }
    }
}
