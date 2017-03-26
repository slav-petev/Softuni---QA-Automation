using BankLibrary;
using NUnit.Framework;
using System;

namespace BankLibraryTests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(30)]
        [Category("BankLibraryTests")]
        public void ShouldCreateBankAccountWithNonNegativeAmountCorrectly(decimal initialAmount)
        {
            var bankAccount = new BankAccount(initialAmount);

            Assert.AreEqual(initialAmount, bankAccount.Amount);
        }

        [Test]
        [Category("BankLibraryTests")]
        public void ShouldThrowArgumentExceptionWhenCreatingBankAccountWithNegativeAmount()
        {
            Assert.Throws<ArgumentException>(() => new BankAccount(-1));
        }

        [Test]
        [Category("BankLibraryTests")]
        public void ShouldThrowArgumentExceptionWhenTryingToWithdrawNegativeAmount()
        {
            var bankAccount = new BankAccount(10);

            Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(-5));

        }

        [Test]
        [Category("BankLibraryTests")]
        public void ShouldThrowArgumentExceptionWhenTryingToWithdrawMoreMoneyThanYouHave()
        {
            var bankAccount = new BankAccount(10);

            Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(15));
        }

        [Test]
        [Category("BankLibraryTests")]
        [TestCase(300, 200, 96)]
        [TestCase(800, 800, -16)]
        [TestCase(2000, 1000, 950)]
        [TestCase(2000, 2000, -100)]
        public void ShouldWithdrawAmountCorrectly(decimal initialAmount,
            decimal withdrawAmount, decimal expectedAmount)
        {
            var bankAccount = new BankAccount(initialAmount);

            bankAccount.Withdraw(withdrawAmount);

            Assert.AreEqual(expectedAmount, bankAccount.Amount);
        }
    }
}
