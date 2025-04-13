using System;

namespace Assignment23
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user for the height of the triangle
            Console.Write("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            // Print the triangle pattern
            PrintTriangle(height);
        }

        // Method to print the right-aligned triangle of stars
        void PrintTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                // Print spaces before the stars to align the triangle to the right
                for (int j = i; j < height; j++)
                {
                    Console.Write(" ");
                }

                // Print the stars
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line after printing one row of the triangle
                Console.WriteLine();
            }
        }
    }
}
