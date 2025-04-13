namespace Assignment14
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter dimension size: ");
            int dimensionSize = int.Parse(Console.ReadLine());
            
            PrintSquare(dimensionSize);
        }

        // Method to print the square pattern
        void PrintSquare(int dimensionSize)
        {
            for (int i = 1; i <= dimensionSize; i++)
            {
                for (int j = 1; j <= dimensionSize; j++)
                {
                    // Print 'X' for borders, otherwise a space
                    if (i == 1 || i == dimensionSize || j == 1 || j == dimensionSize)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
