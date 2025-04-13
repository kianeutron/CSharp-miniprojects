using System;

namespace Assignment33
{
    class Rectangle
    {
        // Private fields for Width and Height
        private double _width;
        private double _height;

        // Constructor to initialize Width and Height with validation
        public Rectangle(double width, double height)
        {
            // Validate the width and height to ensure they are positive
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Width and Height must be greater than zero.");
            }

            _width = width;
            _height = height;
        }

        // Property for Width with validation to ensure positive values
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be greater than zero.");
                }
                _width = value;
            }
        }

        // Property for Height with validation to ensure positive values
        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than zero.");
                }
                _height = value;
            }
        }

        // Calculated property for Area
        public double Area
        {
            get { return _width * _height; }
        }

        // Calculated property for Perimeter
        public double Perimeter
        {
            get { return 2 * (_width + _height); }
        }

        // Method to display the rectangle's details
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {_width}");
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
