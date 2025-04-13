using System;

namespace Assignment28
{
    class Program
    {
        // Start method to create a Circle object and display its information
        static void Start()
        {
            // Create a Circle object with a sample radius
            Circle circle = new Circle(5.0);

            // Display the circle's information (radius and area)
            circle.DisplayInfo();
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            Start();
        }
    }
}
