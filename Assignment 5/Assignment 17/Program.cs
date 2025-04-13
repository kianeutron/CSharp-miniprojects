using System;

namespace Assignment17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new BankAccount with an initial balance of 1000
            BankAccount account = new BankAccount(1000);

            // Display the initial balance
            account.DisplayBalance();

            // Perform a deposit operation
            account.Deposit(500);  // Deposit 500

            // Perform a withdrawal operation
            account.Withdraw(200); // Withdraw 200

            // Display the updated balance
            account.DisplayBalance();
        }
    }
}
