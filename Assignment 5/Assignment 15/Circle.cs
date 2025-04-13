namespace Assignment15
{
    class Circle
    {
        // Public property for radius
        public double Radius { get; set; }

        // Calculated property for area
        public double Area
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }

        // Method to display area of the circle
        public void DisplayArea()
        {
            Console.WriteLine($"Circle with radius {Radius} has an area of {Area:F2}");
        }
    }
}
