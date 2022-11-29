using System;
using Exceptions.Entities.Exceptions;

namespace Exceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
                throw new DomainExceptions("The amount exceeds withdraw limit");
            else
                Balance -= amount;

            if (Balance <= 0)
                throw new DomainExceptions("Not enough balance");
        }

        public override string ToString()
        {
            return Balance.ToString("F2");
        }
    }
}
