
namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter positive integers to calculate the sum and average.");
            Console.WriteLine("Enter 0 or a negative number to stop.");

            // Loop to repeatedly ask the user for input
            while (true)
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                // Stop the loop if the user enters 0 or a negative number
                if (userInput <= 0)
                {
                    break;
                }

                // Add the input number to the list
                numbers.Add(userInput);
            }

            // Call the GetSum and GetAverage methods
            int sum = GetSum(numbers.ToArray());
            int average = GetAverage(numbers.ToArray());

            // Display the sum and average
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
        }

        // Method to calculate the sum of the numbers in the array
        int GetSum(int[] numbers)
        {
            int sum = 0;

            // Loop through the array to calculate the sum
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        // Method to calculate the average of the numbers in the array
        int GetAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;  // To avoid division by zero
            }

            // Calculate and return the average
            return GetSum(numbers) / numbers.Length;
        }
    }
}
