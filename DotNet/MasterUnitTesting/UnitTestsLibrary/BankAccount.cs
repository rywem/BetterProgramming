using System;
using NUnit.Framework;

namespace UnitTestsLibrary
{
    /// <summary>
    /// The demo application for Unit Tests
    /// </summary>
    public class BankAccount
    {
        public int Balance { get; private set; }
        public BankAccount(int startingBalance)
        {
            Balance = startingBalance;
        }

        public void Deposit(int amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(int amount)
        {
            this.Balance -= amount;
        }
    }
    [TestFixture]
    [SetUpFixture]
    public class AccountTests
    {
        public BankAccount Account { get; set; }
        [SetUp]
        public void SetUp()
        {
            //step one, arrage -  "arrange with a starting balance of 100"
            Account = new BankAccount(100);
        }


        [TearDown]
        public void TearDown()
        {
            Account = null;
        }
        [Test]
        public void BankAccountShouldIncreaseOnPositiveDeposit() 
        {
            // pattern:
            // aaa - arrange, act, asset
            //act - "act on the bank account by depositing 100" 
            Account.Deposit(100);
            // assert - "assert the new balance is equal to 200"
            Assert.That(Account.Balance, Is.EqualTo(200));
        }

        [Test]
        public void LessThanOne()
        {
            Account.Withdraw(100);
            Assert.Multiple(() =>
            {
                Assert.That(Account.Balance, Is.EqualTo(0));
                Assert.That(Account.Balance, Is.LessThan(1));
            });
        }
    }
}
