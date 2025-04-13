namespace Assignment26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example input array
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Display the original array
            Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            // Reverse the array using ReverseArray method
            ReverseArray(numbers);

            // Display the reversed array
            Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));
        }

        // Method 1: Reverse the array in place
        static void ReverseArray(int[] numbers)
        {
            int start = 0;
            int end = numbers.Length - 1;

            // Reverse the array in place using two-pointer approach
            while (start < end)
            {
                // Swap the elements at the start and end positions
                int temp = numbers[start];
                numbers[start] = numbers[end];
                numbers[end] = temp;

                // Move the pointers
                start++;
                end--;
            }
        }
    }
}
