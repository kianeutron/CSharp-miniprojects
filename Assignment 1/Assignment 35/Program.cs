using System;

namespace Assignment35
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter three side lengths of the triangle
            Console.WriteLine("Enter the first side length:");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second side length:");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third side length:");
            int side3 = int.Parse(Console.ReadLine());

            // Call the DisplayTriangleValidity method to check if the sides can form a valid triangle
            DisplayTriangleValidity(side1, side2, side3);
        }

        // Method to check if three sides can form a valid triangle
        bool IsTriangle(int side1, int side2, int side3)
        {
            // The sum of the lengths of any two sides of a triangle must be greater than the third side
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }

        // Method to display whether the given sides can form a valid triangle or not
        void DisplayTriangleValidity(int side1, int side2, int side3)
        {
            if (IsTriangle(side1, side2, side3))
            {
                Console.WriteLine("The given side lengths can form a valid triangle.");
            }
            else
            {
                Console.WriteLine("The given side lengths cannot form a valid triangle.");
            }
        }
    }
}
