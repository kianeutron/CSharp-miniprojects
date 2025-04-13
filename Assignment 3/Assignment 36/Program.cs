namespace Assignment36
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user for the maximum number of entries
            Console.Write("Enter the maximum number of numbers: ");
            int maxNumbers = int.Parse(Console.ReadLine());

            // Step 2: Create an array for storing numbers
            int[] numbers = new int[maxNumbers];

            // Step 3: Fill the array with user input
            int filledCount = FillArray(numbers);

            // Step 4: Ask for the search value and find its occurrences
            Console.Write("Enter a number to search for: ");
            int searchValue = int.Parse(Console.ReadLine());

            int occurrences = CountOccurrences(numbers, filledCount, searchValue);

            // Step 5: Display the result
            Console.WriteLine($"The number {searchValue} occurred {occurrences} time(s).");
        }

        // Method 1: Fill the array with user inputs, stop when user enters 0
        int FillArray(int[] array)
        {
            int filledCount = 0;

            while (true)
            {
                Console.Write($"Enter a number (0 to stop): ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }

                if (filledCount < array.Length)
                {
                    array[filledCount] = number;
                    filledCount++;
                }
            }

            return filledCount;
        }

        // Method 2: Count occurrences of the search value in the partly filled array
        int CountOccurrences(int[] array, int filledCount, int searchValue)
        {
            int count = 0;

            for (int i = 0; i < filledCount; i++)
            {
                if (array[i] == searchValue)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
