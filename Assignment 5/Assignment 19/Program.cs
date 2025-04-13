using System;

namespace Assignment19
{
    class Program
    {
        static void Start()
        {
            // Create a new BankAccount object
            BankAccount account = new BankAccount("123-456-789", "Alice Johnson", 500);

            // Display account details
            account.DisplayDetails();

            // Deposit money into the account
            account.Deposit(150);

            // Withdraw money from the account
            account.Withdraw(100);

            // Attempt invalid withdrawal
            account.Withdraw(1000);
        }

        static void Main(string[] args)
        {
            // Call the Start method to initiate program
            Start();
        }
    }
}
