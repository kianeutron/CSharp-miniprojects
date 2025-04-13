namespace Assignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create an integer array with 20 elements
            int[] numbers = new int[20];

            // Step 2: Use FillArray to populate the array with random integers between 1 and 10
            FillArray(numbers);

            // Step 3: Use CountFrequencies to get the frequency count of each number in the array
            int[] frequencies = CountFrequencies(numbers);

            // Step 4: Use DisplayFrequencies to display the frequency of each number
            DisplayFrequencies(frequencies);
        }

        // Method 1: Fills the array with random integers between 1 and 10
        void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 11);  // Random number between 1 and 10
            }
        }

        // Method 2: Counts the frequency of each number in the array (1 to 10)
        int[] CountFrequencies(int[] array)
        {
            int[] frequencies = new int[10];  // Array to store the frequency of numbers from 1 to 10

            foreach (int number in array)
            {
                frequencies[number - 1]++;  // Increment the frequency count for the number
            }

            return frequencies;
        }

        // Method 3: Displays the frequency count of each number from 1 to 10
        void DisplayFrequencies(int[] frequencies)
        {
            Console.WriteLine("\nFrequency of numbers (1 to 10):");
            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}: {frequencies[i]}");
            }
        }
    }
}
