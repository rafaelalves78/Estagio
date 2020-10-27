using System;
using System.Globalization;
using BancoExcecoes.Entities;
using BancoExcecoes.Entities.Exceptions;

namespace BancoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many accounts can you withdraw? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double valueWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                try
                {

                    account.Withdraw(valueWithdraw);
                    Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                }
                catch (DomainException e)
                {
                    Console.Write("ERROR IN WITHDRAW: " + e.Message);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
