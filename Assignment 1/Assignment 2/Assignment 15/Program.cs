using System;

namespace Assignment15
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
            Console.Write("Enter a positive integer to generate its multiplication table: ");
            int number = int.Parse(Console.ReadLine());

            // Display the multiplication table for the entered number
            DisplayMultiplicationTable(number);
        }

        // Method to display the multiplication table for a given number
        void DisplayMultiplicationTable(int number)
        {
            // Loop from 1 to 10 to generate the multiplication table
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
