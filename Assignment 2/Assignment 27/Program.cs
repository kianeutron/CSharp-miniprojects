using System;

namespace Assignment27
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a word or number: ");
            string input = Console.ReadLine();
            
            // Check if input is palindrome
            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }

        // Method to check if the given string is a palindrome
        bool IsPalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;

            // Loop to compare characters from both ends of the string
            while (left < right)
            {
                // Check if characters are the same (case insensitive)
                if (char.ToLower(text[left]) != char.ToLower(text[right]))
                {
                    return false; // Not a palindrome
                }
                left++;
                right--;
            }

            return true; // It's a palindrome
        }
    }
}
