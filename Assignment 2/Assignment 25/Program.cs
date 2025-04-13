using System;

namespace Assignment25
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());
            
            // Check if the number is valid (positive)
            if (number > 0)
            {
                Console.WriteLine($"The factors of {number} are:");
                DisplayFactors(number); // Call method to display factors
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }

        // Method to display all factors of a given number
        void DisplayFactors(int number)
        {
            Console.WriteLine("Factors are:");
            for (int i = 1; i <= number; i++)  // Loop from 1 to the given number
            {
                if (number % i == 0)  // Check if i is a factor of the number
                {
                    Console.WriteLine(i); // Print the factor
                }
            }
        }
    }
}
