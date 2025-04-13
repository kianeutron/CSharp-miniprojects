namespace Assignment31
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create an array with fixed size
            int[] array = new int[10];  // Array with a fixed size of 10

            // Step 2: Add values to the partially filled array
            AddToPartiallyFilledArray(array, 0, 5);
            AddToPartiallyFilledArray(array, 1, 10);
            AddToPartiallyFilledArray(array, 3, 15);
            AddToPartiallyFilledArray(array, 5, 20);

            // Step 3: Calculate the sum of the valid entries (ignore unused elements)
            int sum = CalculateSum(array, 6); // We assume that 6 elements are filled

            // Step 4: Display the contents of the partially filled array (with valid data)
            DisplayPartiallyFilledArray(array, 6); // Display up to the filled length

            // Step 5: Display the sum
            Console.WriteLine($"Sum of filled elements: {sum}");
        }

        // Method 1: Adds a value to a specific index in the array
        void AddToPartiallyFilledArray(int[] array, int index, int value)
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;  // Set value at the given index
            }
        }

        // Method 2: Calculates the sum of valid (filled) elements in the array
        int CalculateSum(int[] array, int filledLength)
        {
            int sum = 0;
            for (int i = 0; i < filledLength; i++)
            {
                sum += array[i];  // Add each element from 0 to the filled length
            }
            return sum;
        }

        // Method 3: Displays the partially filled array, ignoring unused elements
        void DisplayPartiallyFilledArray(int[] array, int filledLength)
        {
            Console.WriteLine("Partially Filled Array:");

            for (int i = 0; i < filledLength; i++)
            {
                Console.WriteLine($"Index {i}: {array[i]}");  // Display only valid data (within the filled length)
            }
        }
    }
}
