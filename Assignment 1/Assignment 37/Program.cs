using System;

namespace Assignment37
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter the shape type
            Console.WriteLine("Enter the shape (Circle, Rectangle, or Triangle):");
            string shape = Console.ReadLine().Trim().ToLower();

            // Call the DisplayShapeArea method to calculate and display the area based on the shape type
            DisplayShapeArea(shape);
        }

        // Method to calculate the area of a circle
        double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate the area of a rectangle
        double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        // Method to calculate the area of a triangle
        double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        // Method to display the area based on the shape type
        void DisplayShapeArea(string shape)
        {
            double area = 0;

            // Switch statement to handle different shape types
            switch (shape)
            {
                case "circle":
                    Console.WriteLine("Enter the radius of the circle:");
                    double radius = double.Parse(Console.ReadLine());
                    area = CalculateCircleArea(radius);
                    break;

                case "rectangle":
                    Console.WriteLine("Enter the length of the rectangle:");
                    double length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width of the rectangle:");
                    double width = double.Parse(Console.ReadLine());
                    area = CalculateRectangleArea(length, width);
                    break;

                case "triangle":
                    Console.WriteLine("Enter the base of the triangle:");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the triangle:");
                    double height = double.Parse(Console.ReadLine());
                    area = CalculateTriangleArea(baseLength, height);
                    break;

                default:
                    Console.WriteLine("Invalid shape entered.");
                    return;
            }

            // Display the calculated area
            Console.WriteLine($"The area of the {shape} is: {area:F2}");
        }
    }
}
