﻿using BancoExcecoes.Entities.Exceptions;
using System;

namespace BancoExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withDrawLimit;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Withdraw (double amount)
        {
            if (amount > WithdrawLimit && amount > Balance)
            {
                throw new DomainException("The amount exceeds withdraw limit!\nNot enough balance!");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enough balance!");
            }

            Balance -= amount;
        }
    }
}