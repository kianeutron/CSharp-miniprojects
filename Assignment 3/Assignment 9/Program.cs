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
            // Step 1: Create a dynamic list to store the entered negative numbers
            List<int> negativeNumbers = new List<int>();

            // Step 2: Prompt the user to enter numbers until a 0 or a positive number is entered
            while (true)
            {
                Console.Write("Enter a number (0 or positive to stop): ");
                int number = int.Parse(Console.ReadLine());

                // Stop the input loop if a non-negative number is entered
                if (number >= 0)
                {
                    Console.WriteLine("Input terminated.");
                    break;
                }

                // Add negative numbers to the list
                negativeNumbers.Add(number);
            }

            // Step 3: Convert the list to an array and count the negative numbers
            int count = CountNegativeNumbers(negativeNumbers.ToArray());

            // Step 4: Display the total count of negative numbers entered
            Console.WriteLine($"\nThe total count of negative numbers entered is: {count}");
        }

        // Method 1: Counts the number of negative numbers in the array
        int CountNegativeNumbers(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
