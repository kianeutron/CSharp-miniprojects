using System;

namespace Assignment37
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsStrongNumber(number))
            {
                Console.WriteLine($"{number} is a strong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a strong number.");
            }
        }

        // Method to check if a number is a strong number
        bool IsStrongNumber(int number)
        {
            int originalNumber = number;
            int sumOfFactorials = 0;

            while (number > 0)
            {
                int digit = number % 10;  // Extract the last digit
                sumOfFactorials += Factorial(digit);  // Add the factorial of the digit
                number /= 10;  // Remove the last digit
            }

            // Check if the sum of factorials equals the original number
            return sumOfFactorials == originalNumber;
        }

        // Method to calculate the factorial of a number
        int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
