using System;

namespace Assignment33
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number to check if it's a palindrome: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }

        // Method to check if the number is a palindrome
        bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            // Reverse the digits of the number
            while (number > 0)
            {
                int lastDigit = number % 10;  // Get the last digit
                reversedNumber = reversedNumber * 10 + lastDigit;  // Shift the reversed number left and add the digit
                number /= 10;  // Remove the last digit from the original number
            }

            // Compare the reversed number with the original number
            return originalNumber == reversedNumber;
        }
    }
}
