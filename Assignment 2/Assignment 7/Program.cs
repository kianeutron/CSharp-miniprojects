

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            int[] numbers = new int[10]; // Array to hold 10 random integers

            // Fill the array with random numbers between 1 and 50
            FillArray(numbers);

            // Count how many odd numbers are in the array
            int oddCount = CountOddNumbers(numbers);

            // Display the result
            Console.WriteLine($"There are {oddCount} odd numbers in the array.");
        }

        // Method to fill the array with random integers between 1 and 50
        void FillArray(int[] numbers)
        {
            Random rand = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 51);  // Generates numbers between 1 and 50
            }
        }

        // Method to count how many odd numbers are in the array
        int CountOddNumbers(int[] numbers)
        {
            int count = 0;

            // Loop through the array to count odd numbers
            foreach (int number in numbers)
            {
                if (number % 2 != 0)  // If the number is odd
                {
                    count++;
                }
            }

            return count;
        }
    }
}
