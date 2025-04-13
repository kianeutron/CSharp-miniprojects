namespace Assignment28
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Initialize the array to be sorted
            int[] array = { 5, 2, 9, 1, 5, 6 };

            // Step 2: Sort the array in ascending order
            SortArrayAscending(array);
            Console.WriteLine("Array sorted in ascending order:");
            DisplaySortedArray(array);

            // Step 3: Sort the array in descending order
            SortArrayDescending(array);
            Console.WriteLine("Array sorted in descending order:");
            DisplaySortedArray(array);
        }

        // Method 1: Sorts the array in ascending order
        void SortArrayAscending(int[] array)
        {
            Array.Sort(array); // Uses the built-in Array.Sort to sort in ascending order
        }

        // Method 2: Sorts the array in descending order
        void SortArrayDescending(int[] array)
        {
            Array.Sort(array); // First sort in ascending order
            Array.Reverse(array); // Then reverse the array to get descending order
        }

        // Method 3: Displays the sorted array
        void DisplaySortedArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
