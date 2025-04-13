namespace Assignment4
{
    using System;

    public class BankAccount
    {
        // Field to hold the balance
        public decimal Balance { get; private set; }

        // Constructor to initialize the balance
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        // Method to display the current balance
        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {Balance:C}");
        }
    }
}
