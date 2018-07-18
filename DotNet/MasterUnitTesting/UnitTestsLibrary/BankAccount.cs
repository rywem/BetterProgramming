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
    public class AccountTests
    {
        [Test]
        public void BankAccountShouldIncreaseOnPositiveDeposit() 
        {
            // pattern:
            // aaa - arrange, act, asset

            //step one, arrage -  "arrange with a starting balance of 100"
            var bankAccount = new BankAccount(100);
            //act - "act on the bank account by depositing 100" 
            bankAccount.Deposit(100);
            // assert - "assert the new balance is equal to 200"
            Assert.That(bankAccount, Is.EqualTo(200));

        }
    }
}
