using System;
using Exceptions.Entities;
using Exceptions.Entities.Exceptions;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.Write("\n\r\n\rEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                acc.Withdraw(amount);

                Console.WriteLine("New balance: " + acc);
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine("Withdraw erro: " + e.Message);
            }
        }
    }
}