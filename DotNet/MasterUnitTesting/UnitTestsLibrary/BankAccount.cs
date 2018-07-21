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
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive " , nameof(amount));
            this.Balance += amount;
        }

        public bool Withdraw(int amount)
        {
            //this.Balance -= amount;
            return false;
        }
    }
    [TestFixture]
    [SetUpFixture]
    public class BankAccountTests
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
        public void MultipleAsserts()
        {
            Account.Withdraw(100);
            Assert.Multiple(() =>
            {
                Assert.That(Account.Balance, Is.EqualTo(0));
                Assert.That(Account.Balance, Is.LessThan(1));
            });
        }

        [Test]
        public void BankAccountShouldThrowOnNonPositiveDeposit()
        {
            //we are expecting an argument to be thrown of type ArgumentException
            var ex = Assert.Throws<ArgumentException>(() => Account.Deposit(-1));

            StringAssert.StartsWith("Deposit amount must be positive", ex.Message);
        }
    }

    [TestFixture]
    public class DataDrivenTests
    {
        private BankAccount ba;
        [SetUp]
        public void SetUp()
        {
            ba = new BankAccount(100);
        }

        public void TestMultipleWithdrawalScenarios(int amountToWithdraw, 
                                    bool shouldSucceed, int expectedBalance)
        {
            var result = ba.Withdraw(amountToWithdraw);
            Warn.If(!result, "Failed for some reason");
        }
    }
}
