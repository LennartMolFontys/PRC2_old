﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigBucksBank
{
    public class Account
    {
        private const decimal maxDebt = 1000m;

        /// <summary>
        /// The name of the owner
        /// </summary>
        public String Name { get; private set; }

        /// <summary>
        /// The balance of the account.
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// The maximum debt for this account.
        /// </summary>
        public decimal MaxDebt { get { return maxDebt; } }

        /// <summary>
        /// Creates an account with balance zero.
        /// </summary>
        /// <param name="name">The name of the owner.</param>
        public Account(String name)
            : this(name, 0)
        {
        }

        /// <summary>
        /// Creates an account with a given balance.
        /// </summary>
        /// <param name="name">The name of the owner.</param>
        /// <param name="initialCredit">The initial credit.</param>
        public Account(String name, decimal initialCredit)
        {
            Name = name;
            Balance = initialCredit;
        }

        /// <summary>
        /// Removes some amount from the account balance.
        /// </summary>
        /// <param name="amount">The amount to remove. Must be a positive value.</param>
        /// <returns>True if enough credit is present, false otherwise.</returns>
        public void Withdraw(decimal amount)
        {
            if ((Balance + MaxDebt) >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new NotEnoughCreditException("Balance to low");
            }
        }

        /// <summary>
        /// Adds some amount on the account balance.
        /// </summary>
        /// <param name="amount">The amount to add. Must be a positive value.</param>
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                if ((Balance + amount) <= decimal.MaxValue)
                {
                    Balance += amount;
                }
                else
                {
                    throw new OverflowException();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Creates a debug string.
        /// </summary>
        /// <returns>A string containing the account properties.</returns>
        public override string ToString()
        {
            return "Account: " + Name + ", balance : " + Balance;
        }
    }
}
