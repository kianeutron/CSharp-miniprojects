namespace Assignment30
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Initialize a 2D array for the multiplication table
            int[,] table = new int[10, 10]; // 10x10 table

            // Step 2: Fill the multiplication table
            FillMultiplicationTable(table);

            // Step 3: Display the multiplication table
            DisplayMultiplicationTable(table);
        }

        // Method 1: Fills the table with multiplication values
        void FillMultiplicationTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)  // Rows
            {
                for (int j = 0; j < table.GetLength(1); j++)  // Columns
                {
                    table[i, j] = (i + 1) * (j + 1); // Fill with the result of multiplication (i+1) * (j+1)
                }
            }
        }

        // Method 2: Displays the multiplication table
        void DisplayMultiplicationTable(int[,] table)
        {
            Console.WriteLine("Multiplication Table:");

            for (int i = 0; i < table.GetLength(0); i++)  // Rows
            {
                for (int j = 0; j < table.GetLength(1); j++)  // Columns
                {
                    Console.Write($"{table[i, j],4} "); // Display the number with some padding for clarity
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
