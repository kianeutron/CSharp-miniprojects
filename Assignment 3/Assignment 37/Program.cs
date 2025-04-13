namespace Assignment37
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Initialize the dice count array with 6 zeros
            int[] diceCounts = new int[6];

            // Step 2: Simulate throwing the dice 6000 times
            ThrowDice(diceCounts, 6000);

            // Step 3: Display the results
            DisplayResults(diceCounts);
        }

        // Method 1: Simulates throwing a dice and updating the counts
        void ThrowDice(int[] counts, int numThrows)
        {
            Random random = new Random();
            
            for (int i = 0; i < numThrows; i++)
            {
                int diceValue = random.Next(1, 7); // Generate random number between 1 and 6
                counts[diceValue - 1]++; // Increment the appropriate dice value count
            }
        }

        // Method 2: Displays the counts for each dice value (1 to 6)
        void DisplayResults(int[] counts)
        {
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine($"Dice {i + 1}: {counts[i]} times");
            }
        }
    }
}
