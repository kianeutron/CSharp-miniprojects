namespace Assignment34
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Create an integer array to store 3 user input values
            int[] numbers = new int[3];

            // Step 1: Fill the array with user input
            FillArrayWithUserInput(numbers);

            // Step 2: Display the sum and average of the numbers in the array
            int sum = CalculateSum(numbers);
            double average = CalculateAverage(numbers);

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
        }

        // Method 1: Fill the array with user input values
        void FillArrayWithUserInput(int[] array)
        {
            Console.WriteLine("Please enter 3 integers:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());  // Read and store the number
            }
        }

        // Method 2: Calculate the sum of the array values
        int CalculateSum(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;  // Add each number to the sum
            }
            return sum;
        }

        // Method 3: Calculate the average of the array values
        double CalculateAverage(int[] array)
        {
            int sum = CalculateSum(array);
            double average = (double)sum / array.Length;  // Calculate the average
            return average;
        }
    }
}
