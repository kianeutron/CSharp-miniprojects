using System;

namespace Assignment34
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Pre-set PIN (the actual PIN)
            int actualPIN = 1234;

            // Ask the user to enter their 4-digit PIN
            Console.WriteLine("Enter your 4-digit PIN:");
            int userPIN = int.Parse(Console.ReadLine());

            // Call the DisplayPINValidation method to check if the PIN is correct
            DisplayPINValidation(userPIN, actualPIN);
        }

        // Method to validate the user-provided PIN against the actual PIN
        bool ValidatePIN(int userPIN, int actualPIN)
        {
            return userPIN == actualPIN;
        }

        // Method to display whether the user-provided PIN is correct or not
        void DisplayPINValidation(int userPIN, int actualPIN)
        {
            if (ValidatePIN(userPIN, actualPIN))
            {
                Console.WriteLine("PIN is correct.");
            }
            else
            {
                Console.WriteLine("Incorrect PIN.");
            }
        }
    }
}
