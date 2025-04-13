namespace Assignment28
{
    public class Rectangle
    {
        // Fields for Width and Height
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor to initialize Width and Height
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return Width * Height;
        }

        // Method to calculate the perimeter of the rectangle
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
