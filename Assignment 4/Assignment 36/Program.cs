using System;

namespace Assignment36
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a bank with capacity for 2 accounts
            Bank bank = new Bank(2);

            // Create accounts
            bank.CreateAccount("Alice", 1000.00);
            bank.CreateAccount("Bob", 500.00);

            // Deposit and withdraw funds
            bank.Deposit(0, 200.00); // Alice deposits $200
            bank.Withdraw(1, 100.00); // Bob withdraws $100

            // Display account details
            bank.DisplayAccountDetails(0); // Display Alice's account details
            bank.DisplayAccountDetails(1); // Display Bob's account details

            // Attempt to withdraw from an invalid account
            bank.Withdraw(2, 50.00); // Invalid account
        }
    }
}
