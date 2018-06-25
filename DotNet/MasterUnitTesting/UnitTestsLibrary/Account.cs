using System;
using NUnit.Framework;

namespace UnitTestsLibrary
{
    /// <summary>
    /// The demo application for Unit Tests
    /// </summary>
    public class Account
    {
        public int Balance { get; private set; }
        public Account(int startingBalance)
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
            //assertions -> a condition should hold after a certain operation

        }
    }
}
