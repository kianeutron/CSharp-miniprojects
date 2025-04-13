namespace Assignment17
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user how many elements they want in the array
            Console.Write("Enter the number of elements in the array: ");
            int arraySize = int.Parse(Console.ReadLine());

            // Step 2: Create an array of doubles
            double[] numbers = new double[arraySize];

            // Step 3: Use FillArray to populate the array with random values
            FillArray(numbers);

            // Step 4: Use DisplayArray to display the values in the array
            DisplayArray(numbers);
        }

        // Method 1: Fill the array with random double values between 0.0 and 1.0
        void FillArray(double[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble(); // Random value between 0.0 and 1.0
            }
        }

        // Method 2: Display all the values in the array
        void DisplayArray(double[] array)
        {
            Console.WriteLine("\nArray values:");
            foreach (double number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
