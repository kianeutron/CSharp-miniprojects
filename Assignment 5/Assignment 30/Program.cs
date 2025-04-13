using System;

namespace Assignment30
{
    class Program
    {
        // Start method to create an account and perform transactions
        static void Start()
        {
            // Create a new account
            Account myAccount = new Account("John Doe");

            // Display initial account info
            myAccount.DisplayAccountInfo();

            // Deposit funds and show updated balance
            myAccount.Deposit(500);
            myAccount.DisplayAccountInfo();

            // Try to deposit an invalid amount
            myAccount.Deposit(-100);
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            Start();
        }
    }
}
