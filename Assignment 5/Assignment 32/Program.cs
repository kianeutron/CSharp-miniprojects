using System;

namespace Assignment32
{
    class Program
    {
        // Start method to create and manage a bank account
        static void Start()
        {
            // Create a BankAccount object with an initial balance
            BankAccount myAccount = new BankAccount("123456789", 500.00);

            // Display account info
            myAccount.DisplayAccountInfo();

            // Deposit funds
            myAccount.Deposit(200.00);

            // Withdraw funds
            myAccount.Withdraw(100.00);

            // Try to withdraw more than the available balance
            myAccount.Withdraw(700.00);
        }

        // Main method to run the application
        static void Main(string[] args)
        {
            Start();
        }
    }
}
