namespace Assignment28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start method to execute the program logic
            new Program().Start();
        }

        public void Start()
        {
            // Prompt the user for the width and height
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the rectangle:");
            double height = double.Parse(Console.ReadLine());

            // Create a new Rectangle object with the user inputs
            Rectangle rectangle = new Rectangle(width, height);

            // Calculate and display the area and perimeter
            double area = rectangle.CalculateArea();
            double perimeter = rectangle.CalculatePerimeter();

            // Display the results
            Console.WriteLine($"\nArea of Rectangle: {area:F2}");
            Console.WriteLine($"Perimeter of Rectangle: {perimeter:F2}");
        }
    }
}
