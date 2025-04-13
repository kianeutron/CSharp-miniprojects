using System;

namespace Assignment30
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            // Call the CountOddDigits method to count odd digits and display the result
            int oddDigitCount = CountOddDigits(number);
            Console.WriteLine($"The number of odd digits in {number} is: {oddDigitCount}");
        }

        // Method to count the number of odd digits in a given number
        int CountOddDigits(int number)
        {
            int count = 0;

            // Loop through the number and check each digit
            while (number != 0)
            {
                // Extract the last digit
                int digit = number % 10;

                // Check if the digit is odd
                if (digit % 2 != 0)
                {
                    count++;
                }

                // Remove the last digit
                number /= 10;
            }

            return count;
        }
    }
}
