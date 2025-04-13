

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            int[] numbers = new int[5];  // Array to hold 5 user-entered integers

            // Ask the user to enter 5 integers
            Console.WriteLine("Enter 5 integers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Call the method to find and display the minimum and maximum values
            FindMinMax(numbers);
        }

        // Method to find and display the minimum and maximum values from the array
        void FindMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            // Loop through each number and compare to find min and max
            foreach (int number in numbers)
            {
                if (number < min)  // Check if current number is smaller than min
                {
                    min = number;
                }

                if (number > max)  // Check if current number is larger than max
                {
                    max = number;
                }
            }

            // Display the results
            Console.WriteLine($"The smallest number entered is: {min}");
            Console.WriteLine($"The largest number entered is: {max}");
        }
    }
}
