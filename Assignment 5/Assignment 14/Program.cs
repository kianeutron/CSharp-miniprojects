using System;

namespace Assignment14
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        // Start method that executes the main program flow
        static void Start()
        {
            // Create a new BankAccount object
            BankAccount account = ReadBankAccount();

            // Display account details
            account.DisplayAccountInfo();

            // Perform some transactions (Deposit and Withdraw)
            account.Deposit(1000);
            account.Withdraw(200);
            account.DisplayAccountInfo();
        }

        // Method to create and return a new BankAccount object based on user input
        static BankAccount ReadBankAccount()
        {
            Console.Write("Enter account holder name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            return new BankAccount(holderName, initialBalance);
        }
    }
}
