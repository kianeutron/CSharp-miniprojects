using System;

namespace Assignment33
{
    class Program
    {
        // Start method to create and manage a rectangle
        static void Start()
        {
            try
            {
                // Create a Rectangle object with valid width and height
                Rectangle myRectangle = new Rectangle(5, 10);

                // Display the details of the rectangle
                myRectangle.DisplayInfo();

                // Modify width and height
                myRectangle.Width = 8;
                myRectangle.Height = 15;

                // Display the updated rectangle details
                myRectangle.DisplayInfo();
            }
            catch (ArgumentException ex)
            {
                // Catch validation exceptions for invalid width/height
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Main method to run the application
        static void Main(string[] args)
        {
            Start();
        }
    }
}
