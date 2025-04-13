namespace Assignment28
{
    public class Circle
    {
        // Private field for Radius
        private double _radius;

        // Constructor to initialize the radius
        public Circle(double radius)
        {
            _radius = radius;
        }

        // Calculated property for Area (using the formula π * Radius^2)
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(_radius, 2); // Area calculation
            }
        }

        // Method to display the radius and area of the circle
        public void DisplayInfo()
        {
            Console.WriteLine($"Circle Radius: {_radius}");
            Console.WriteLine($"Circle Area: {Area}");
        }
    }
}

