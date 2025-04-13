namespace Assignment20
{
    public class Rectangle
    {
        // Private backing fields for Length and Width
        private double length;
        private double width;

        // Public property for Length with validation logic
        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Length must be greater than zero.");
                }
            }
        }

        // Public property for Width with validation logic
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Width must be greater than zero.");
                }
            }
        }

        // Constructor to initialize Length and Width
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Method to calculate and return the area of the rectangle
        public double GetArea()
        {
            return Length * Width;
        }

        // Method to calculate and return the perimeter of the rectangle
        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        // Method to display the area and perimeter
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
        }
    }
}
