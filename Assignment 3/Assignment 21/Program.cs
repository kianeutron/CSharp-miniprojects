namespace Assignment21
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

            // Step 2: Create an integer array to store the values
            int[] numbers = new int[arraySize];

            // Step 3: Ask the user to enter the values for the array
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Step 4: Ask the user to enter the value to search for
            Console.Write("Enter the value to search for: ");
            int valueToSearch = int.Parse(Console.ReadLine());

            // Step 5: Use SearchValue to find the index of the value in the array
            int index = SearchValue(numbers, valueToSearch);

            // Step 6: Use DisplaySearchResult to show the result
            DisplaySearchResult(index);
        }

        // Method 1: Searches for the value in the array and returns its index
        int SearchValue(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i; // Return the index of the value if found
                }
            }
            return -1; // Return -1 if the value is not found
        }

        // Method 2: Displays the search result (either the index or "not found")
        void DisplaySearchResult(int index)
        {
            if (index >= 0)
            {
                Console.WriteLine($"\nThe value was found at index {index}.");
            }
            else
            {
                Console.WriteLine("\nThe value was not found in the array.");
            }
        }
    }
}
