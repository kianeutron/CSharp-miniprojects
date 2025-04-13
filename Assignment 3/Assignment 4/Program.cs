namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create an array to store the ages
            int[] ages = new int[10];

            // Step 2: Use ReadAges to populate the array
            ReadAges(ages);

            // Step 3: Use CountEligibleVoters to calculate the number of eligible voters
            int eligibleCount = CountEligibleVoters(ages);

            // Step 4: Display the results
            Console.WriteLine($"\nNumber of eligible voters (age >= 18): {eligibleCount}");
        }

        // Method 1: Reads ages into the array
        void ReadAges(int[] ages)
        {
            Console.WriteLine("Enter the ages of 10 people:");
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Age for person {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());

                // Validate that the age is a non-negative value
                while (ages[i] < 0)
                {
                    Console.Write("Invalid age. Please enter a non-negative value: ");
                    ages[i] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Method 2: Returns the number of people eligible to vote (age >= 18)
        int CountEligibleVoters(int[] ages)
        {
            int count = 0;
            foreach (int age in ages)
            {
                if (age >= 18)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
