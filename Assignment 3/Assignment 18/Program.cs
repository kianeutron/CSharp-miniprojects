namespace Assignment18
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user to enter the number of elements in the array
            Console.Write("Enter the number of elements in the array: ");
            int arraySize = int.Parse(Console.ReadLine());

            // Step 2: Create an array to hold the integers
            int[] numbers = new int[arraySize];

            // Step 3: Ask the user to enter the values for the array
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Step 4: Use DisplayLargestValue to find and display the largest number
            DisplayLargestValue(numbers);
        }

        // Method 1: Returns the largest value in the array
        int FindLargest(int[] array)
        {
            int largest = array[0]; // Assume the first element is the largest
            foreach (int number in array)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }
            return largest;
        }

        // Method 2: Displays the largest value in the array
        void DisplayLargestValue(int[] array)
        {
            int largest = FindLargest(array); // Get the largest value using FindLargest
            Console.WriteLine($"\nThe largest value in the array is: {largest}");
        }
    }
}
