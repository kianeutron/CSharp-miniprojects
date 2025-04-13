using System;

namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        // Start method that handles the user input and displays results
        static void Start()
        {
            // Create a circle based on user input for radius
            Circle circle = ReadCircle();

            // Display the area of the circle
            circle.DisplayArea();
        }

        // Method to create a circle object based on user input
        static Circle ReadCircle()
        {
            Console.Write("Enter radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            return new Circle { Radius = radius };
        }
    }
}
