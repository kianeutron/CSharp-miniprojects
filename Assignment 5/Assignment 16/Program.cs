using System;

namespace Assignment16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Rectangle object
            Rectangle rectangle = new Rectangle(10, 20);

            // Display the original rectangle dimensions
            Console.WriteLine("Original Rectangle:");
            DisplayRectangle(rectangle);

            // Pass by value (won't change the original object)
            ManipulateByValue(rectangle);
            Console.WriteLine("\nAfter Manipulation by Value:");
            DisplayRectangle(rectangle);

            // Pass by reference (will change the original object)
            ManipulateByReference(ref rectangle);
            Console.WriteLine("\nAfter Manipulation by Reference:");
            DisplayRectangle(rectangle);
        }

        // Method to display rectangle dimensions
        static void DisplayRectangle(Rectangle rectangle)
        {
            Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}");
        }

        // Method to manipulate the rectangle by value (won't change the original object)
        static void ManipulateByValue(Rectangle rectangle)
        {
            rectangle.Width = 100;  // Change only within this method
            rectangle.Height = 200;
            Console.WriteLine("Inside ManipulateByValue method - values changed");
        }

        // Method to manipulate the rectangle by reference (will change the original object)
        static void ManipulateByReference(ref Rectangle rectangle)
        {
            rectangle = new Rectangle(50, 75);  // Changes the actual object passed
            Console.WriteLine("Inside ManipulateByReference method - values changed");
        }
    }
}
