using System;

namespace Assignment32
{
    class BankAccount
    {
        // Properties for AccountNumber and Balance
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        // Constructor to initialize AccountNumber and Balance
        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            // Initial balance should not be negative
            if (initialBalance >= 0)
            {
                Balance = initialBalance;
            }
            else
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
        }

        // Method to deposit funds
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. Current Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw funds
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. Current Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        // Method to display account details
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }
}
