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
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            // Call the DisplayPalindromeCheck method to check and display if the number is a palindrome
            DisplayPalindromeCheck(number);
        }

        // Method to check if the given number is a palindrome
        bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            // Reverse the number
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            // Check if the reversed number is equal to the original number
            return originalNumber == reversedNumber;
        }

        // Method to display if the given number is a palindrome or not
        void DisplayPalindromeCheck(int number)
        {
            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }
    }
}
