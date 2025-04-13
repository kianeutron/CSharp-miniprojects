using System;

namespace Assignment30
{
    class Account
    {
        // Private fields for account details
        private string _accountHolder;
        private double _amount;

        // Constructor to initialize the account holder
        public Account(string accountHolder)
        {
            _accountHolder = accountHolder;
            _amount = 0; // Initializing with 0
        }

        // Public method to deposit funds
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _amount += amount;
                LogTransaction($"Deposited {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount!");
            }
        }

        // Private method to log transactions (can't be accessed outside the Account class)
        private void LogTransaction(string message)
        {
            // Simulating logging
            Console.WriteLine($"Transaction Log: {message}");
        }

        // Public method to display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {_accountHolder}");
            Console.WriteLine($"Account Balance: {_amount}");
        }
    }
}
