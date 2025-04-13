namespace Assignment25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the number of Fibonacci numbers to generate
            Console.Write("Enter the number of Fibonacci numbers to generate: ");
            int count = int.Parse(Console.ReadLine());

            // Generate the Fibonacci sequence and display it
            List<int> fibonacciNumbers = GenerateFibonacci(count);
            Console.WriteLine("Fibonacci Sequence: " + string.Join(", ", fibonacciNumbers));
        }

        // Method 1: Generate a list of Fibonacci numbers up to the specified count
        static List<int> GenerateFibonacci(int count)
        {
            List<int> fibonacci = new List<int>();

            // Generate the Fibonacci sequence
            if (count > 0)
                fibonacci.Add(0);  // First Fibonacci number
            if (count > 1)
                fibonacci.Add(1);  // Second Fibonacci number

            for (int i = 2; i < count; i++)
            {
                // Each number is the sum of the two previous numbers
                int nextNumber = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci.Add(nextNumber);
            }

            return fibonacci;
        }
    }
}
