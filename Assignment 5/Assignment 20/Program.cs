using System;

namespace Assignment20
{
    class Program
    {
        // Start method to execute the program
        static void Start()
        {
            // Create a new Rectangle object with initial values
            Rectangle rectangle = new Rectangle(5, 3);

            // Display the rectangle details (area and perimeter)
            rectangle.DisplayDetails();

            // Try setting invalid values for validation testing
            rectangle.Length = -4; // Invalid length
            rectangle.Width = 0;   // Invalid width

            // Display updated details (without invalid values)
            rectangle.DisplayDetails();
        }

        // Main method to call the Start method
        static void Main(string[] args)
        {
            Start();
        }
    }
}
