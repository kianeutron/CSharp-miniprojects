namespace Assignment33
{
    class Program
    {
        // Constants for array size, min, and max values
        const int ArraySize = 20;  // Number of elements in the array
        const int MinValue = 1;    // Minimum possible value
        const int MaxValue = 100;  // Maximum possible value

        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create an integer array with 20 elements
            int[] array = new int[ArraySize];

            // Step 2: Fill the array with random values
            FillArray(array);

            // Step 3: Display the array
            DisplayArray(array);

            // Step 4: Find the smallest number in the array
            int smallest = FindSmallestValue(array);

            // Step 5: Display the smallest value
            Console.WriteLine($"The smallest value in the array is: {smallest}");
        }

        // Method 1: Fills the array with random values between MinValue and MaxValue
        void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(MinValue, MaxValue + 1);  // Generate a random number between 1 and 100
            }
        }

        // Method 2: Displays the values of the array
        void DisplayArray(int[] array)
        {
            Console.WriteLine("Array of Random Integers:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index {i}: {array[i]}");
            }
        }

        // Method 3: Finds and returns the smallest value in the array
        int FindSmallestValue(int[] array)
        {
            int smallest = array[0];  // Assume the first element is the smallest initially

            for (int i = 1; i < array.Length; i++)  // Iterate over the rest of the array
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];  // Update the smallest value if a smaller one is found
                }
            }

            return smallest;  // Return the smallest value
        }
    }
}
