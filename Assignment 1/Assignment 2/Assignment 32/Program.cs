using System;

namespace Assignment32
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number to check if it's an Armstrong number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsArmstrong(number))
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }

        // Method to check if a number is an Armstrong number
        bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int numDigits = number.ToString().Length;  // Get the number of digits in the number
            int sumOfPowers = 0;

            while (number > 0)
            {
                int digit = number % 10;  // Extract the last digit
                sumOfPowers += (int)Math.Pow(digit, numDigits);  // Raise it to the power of the number of digits
                number /= 10;  // Remove the last digit
            }

            // Check if the sum of powers equals the original number
            return sumOfPowers == originalNumber;
        }
    }
}
