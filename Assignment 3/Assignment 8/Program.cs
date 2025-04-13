namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create a dynamic list to store the positive numbers
            List<int> numbers = new List<int>();

            // Step 2: Prompt the user to enter numbers until 0 or a negative number is entered
            while (true)
            {
                Console.Write("Enter a positive number (0 or negative to stop): ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Input terminated.");
                    break;
                }

                numbers.Add(number);
            }

            // Step 3: Convert the list to an array and calculate the sum
            int sum = CalculateSum(numbers.ToArray());

            // Step 4: Display the total sum
            Console.WriteLine($"\nThe sum of all positive numbers entered is: {sum}");
        }

        // Method 1: Calculates the sum of all numbers in the array
        int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
