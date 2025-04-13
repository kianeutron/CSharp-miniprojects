using System;

namespace Assignment24
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter their balance
            Console.WriteLine("Enter your account balance:");
            int balance = int.Parse(Console.ReadLine());

            // Ask the user to enter the withdrawal amount
            Console.WriteLine("Enter the withdrawal amount:");
            int amount = int.Parse(Console.ReadLine());

            // Use IsValidWithdrawal to check if the withdrawal can be made
            if (IsValidWithdrawal(balance, amount))
            {
                Console.WriteLine("Withdrawal is allowed.");
            }
            else
            {
                Console.WriteLine("Withdrawal is not allowed.");
            }
        }

        // Method to check if the withdrawal is valid
        bool IsValidWithdrawal(int balance, int amount)
        {
            // Check if the amount is less than or equal to the balance
            if (amount <= balance)
            {
                // Check if the amount is a multiple of 10
                if (amount % 10 == 0)
                {
                    return true; // Withdrawal is allowed
                }
                else
                {
                    Console.WriteLine("The amount must be a multiple of 10.");
                    return false; // Withdrawal not allowed
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return false; // Withdrawal not allowed
            }
        }
    }
}
