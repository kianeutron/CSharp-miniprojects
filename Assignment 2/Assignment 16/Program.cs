

namespace Assignment16
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Initialize an empty list to store the entered numbers
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter positive integers. To stop and calculate the sum, enter 0 or a negative number.");

            while (true)
            {
                // Ask the user for a positive integer
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                // Check if the input is 0 or a negative number to stop
                if (number <= 0)
                    break;

                // Add the valid positive number to the list
                numbers.Add(number);
            }

            // Calculate and display the total sum of the entered numbers
            int totalSum = GetTotalSum(numbers.ToArray());
            Console.WriteLine($"The total sum is: {totalSum}");
        }

        // Method to calculate the sum of the numbers in the array
        int GetTotalSum(int[] numbers)
        {
            int sum = 0;

            // Loop through the array and accumulate the sum
            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }
    }
}
