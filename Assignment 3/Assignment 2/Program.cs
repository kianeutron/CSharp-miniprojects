namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create an array for storing temperatures for 7 days
            int[] temperatures = new int[7];

            // Step 2: Read temperatures into the array using ReadTemperatures
            ReadTemperatures(temperatures);

            // Step 3: Get the number of cold and hot days
            int coldDays = GetNumberOfColdDays(temperatures);
            int hotDays = GetNumberOfHotDays(temperatures);

            // Step 4: Display results
            Console.WriteLine($"\nNumber of cold days (<10°C): {coldDays}");
            Console.WriteLine($"Number of hot days (>25°C): {hotDays}");
            Console.WriteLine($"Number of normal days: {temperatures.Length - (coldDays + hotDays)}");
        }

        // Method 1: Reads daily temperatures into the array
        void ReadTemperatures(int[] temperatures)
        {
            Console.WriteLine("Enter the temperatures for 7 days in °C:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write($"Day {i + 1}: ");
                temperatures[i] = int.Parse(Console.ReadLine());
            }
        }

        // Method 2: Returns the number of cold days (<10°C)
        int GetNumberOfColdDays(int[] temperatures)
        {
            int coldCount = 0;
            foreach (int temp in temperatures)
            {
                if (temp < 10)
                {
                    coldCount++;
                }
            }
            return coldCount;
        }

        // Method 3: Returns the number of hot days (>25°C)
        int GetNumberOfHotDays(int[] temperatures)
        {
            int hotCount = 0;
            foreach (int temp in temperatures)
            {
                if (temp > 25)
                {
                    hotCount++;
                }
            }
            return hotCount;
        }
    }
}
