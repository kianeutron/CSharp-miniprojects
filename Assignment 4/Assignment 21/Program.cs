namespace Assignment21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example input array
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            
            // Calling the method to count even and odd numbers
            CountEvenOdd(numbers);
        }

        // Method to count even and odd numbers in the array
        static void CountEvenOdd(int[] numbers)
        {
            int evenCount = 0;
            int oddCount = 0;

            // Loop through the array to count even and odd numbers
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;  // Increment even count
                }
                else
                {
                    oddCount++;  // Increment odd count
                }
            }

            // Display the results
            Console.WriteLine($"Even: {evenCount}");
            Console.WriteLine($"Odd: {oddCount}");
        }
    }
}
