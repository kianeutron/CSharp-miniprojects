namespace Assignment25
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Initialize an integer array
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Step 2: Display the original array
            Console.WriteLine("Original Array:");
            DisplayReversedArray(numbers);

            // Step 3: Reverse the array using ReverseArray
            int[] reversedArray = ReverseArray(numbers);

            // Step 4: Display the reversed array
            Console.WriteLine("\nReversed Array:");
            DisplayReversedArray(reversedArray);
        }

        // Method 1: Reverse the contents of an array
        int[] ReverseArray(int[] array)
        {
            int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }

        // Method 2: Display the contents of an array
        void DisplayReversedArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
