namespace Assignment19
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

            // Step 4: Use DisplaySumAndAverage to calculate and display the sum and average
            DisplaySumAndAverage(numbers);
        }

        // Method 1: Calculates and returns the sum of the values in the array
        int CalculateSum(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return sum;
        }

        // Method 2: Calculates and returns the average of the values in the array
        double CalculateAverage(int[] array)
        {
            int sum = CalculateSum(array); // Reuse CalculateSum to get the sum
            return (double)sum / array.Length;
        }

        // Method 3: Displays the sum and average of the array
        void DisplaySumAndAverage(int[] array)
        {
            int sum = CalculateSum(array); // Get the sum
            double average = CalculateAverage(array); // Get the average

            // Display the results
            Console.WriteLine($"\nThe sum of the array is: {sum}");
            Console.WriteLine($"The average of the array is: {average:F2}"); // Displays the average with 2 decimal places
        }
    }
}
