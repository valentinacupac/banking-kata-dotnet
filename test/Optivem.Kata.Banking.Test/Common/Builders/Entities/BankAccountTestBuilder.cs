﻿using Optivem.Kata.Banking.Core.Domain.BankAccounts;
using System;

namespace Optivem.Kata.Banking.Test.Common.Builders.Entities
{
    internal class BankAccountTestBuilder
    {
        public static BankAccountTestBuilder BankAccount()
        {
            return new BankAccountTestBuilder();
        }

        private string _accountNumber;
        private string _firstName;
        private string _lastName;
        private DateOnly _openingDate;
        private int _balance;

        public BankAccountTestBuilder()
        {
            _accountNumber = BankAccountDefaults.DefaultAccountNumber;
            _firstName = BankAccountDefaults.DefaultFirstName;
            _lastName = BankAccountDefaults.DefaultLastName;
            _openingDate = BankAccountDefaults.DefaultOpeningDate;
            _balance = BankAccountDefaults.DefaultBalance;
        }

        public BankAccountTestBuilder WithAccountNumber(string accountNumber)
        {
            _accountNumber = accountNumber;
            return this;
        }

        public BankAccountTestBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public BankAccountTestBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public BankAccountTestBuilder WithOpeningDate(DateOnly openingDate)
        {
            _openingDate = openingDate;
            return this;
        }

        public BankAccountTestBuilder WithBalance(int balance)
        {
            _balance = balance;
            return this;
        }

        public BankAccount Build()
        {
            var accountNumber = AccountNumber.From(_accountNumber);
            var accountHolderName = AccountHolderName.From(_firstName, _lastName);
            var balance = Balance.From(_balance);
            return new BankAccount(accountNumber, accountHolderName, _openingDate, balance);
        }
    }
}