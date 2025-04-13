using System;

namespace Assignment29
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter three numbers
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());

            // Call the DisplaySmallest method to find and display the smallest number
            DisplaySmallest(num1, num2, num3);
        }

        // Method to find and return the smallest of three numbers
        int FindSmallest(int num1, int num2, int num3)
        {
            // Use Math.Min to find the smallest number
            int smallest = Math.Min(num1, Math.Min(num2, num3));
            return smallest;
        }

        // Method to display the smallest of three numbers
        void DisplaySmallest(int num1, int num2, int num3)
        {
            // Call FindSmallest to get the smallest number
            int smallest = FindSmallest(num1, num2, num3);

            // Display the smallest number
            Console.WriteLine($"The smallest of the three numbers is: {smallest}");
        }
    }
}
