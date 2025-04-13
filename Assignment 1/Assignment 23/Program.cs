
namespace Assignment23
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Enter the length of the first side:");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side:");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side:");
            int side3 = int.Parse(Console.ReadLine());

            // Call the method to determine the triangle type
            DetermineTriangleType(side1, side2, side3);
        }

        void DetermineTriangleType(int side1, int side2, int side3)
        {
            // Check if the triangle is Equilateral
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            // Check if the triangle is Isosceles
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            // Check if the triangle is Scalene
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
