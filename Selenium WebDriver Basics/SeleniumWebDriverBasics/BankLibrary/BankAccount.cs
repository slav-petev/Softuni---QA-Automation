using System;

namespace BankLibrary
{
    public class BankAccount
    {
        decimal amount;

        public BankAccount(decimal initAmount)
        {
            if (initAmount < 0)
                throw new ArgumentException("Amount can not be negative!");

            this.Amount = initAmount;
        }

        public decimal Amount { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit can not be negative!");
            }
            this.Amount += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Cannot withdraw negative amount!");

            if (this.Amount <= 0)
                throw new InvalidOperationException("Your account is empty");

            if (amount > this.Amount)
                throw new InvalidOperationException("Cannot withdraw more money than you have!");

            if (amount < 1000)
            {
                amount += (amount * 0.02m);
                this.Amount -= amount;
            }
            else
            {
                amount += (amount * 0.05m);
                this.Amount -= amount;
            }
        }
    }
}
