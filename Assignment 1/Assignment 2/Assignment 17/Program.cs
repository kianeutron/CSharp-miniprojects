using System;

namespace Assignment17
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user for a positive integer
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            // Reverse the number and display the result
            int reversedNumber = ReverseNumber(number);
            Console.WriteLine($"The reversed number is: {reversedNumber}");
        }

        // Method to reverse the digits of the number
        int ReverseNumber(int number)
        {
            int reversed = 0;

            // Use a loop to reverse the digits of the number
            while (number > 0)
            {
                // Get the last digit and append it to the reversed number
                int lastDigit = number % 10;
                reversed = reversed * 10 + lastDigit;

                // Remove the last digit from the original number
                number = number / 10;
            }

            return reversed;
        }
    }
}
