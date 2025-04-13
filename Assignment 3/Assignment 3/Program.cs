namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Prompt the user to enter the total number of scores
            Console.Write("Enter the total number of scores: ");
            int totalScores = int.Parse(Console.ReadLine());

            // Step 2: Prompt the user to enter the pass mark
            Console.Write("Enter the pass mark: ");
            int passMark = int.Parse(Console.ReadLine());

            // Step 3: Create an array to store the exam results
            int[] results = new int[totalScores];

            // Step 4: Use ReadResults to populate the array
            ReadResults(results);

            // Step 5: Use CountPassingScores and CountFailingScores to calculate the results
            int passingCount = CountPassingScores(results, passMark);
            int failingCount = CountFailingScores(results, passMark);

            // Step 6: Display the results
            Console.WriteLine($"\nNumber of passing scores (>= {passMark}): {passingCount}");
            Console.WriteLine($"Number of failing scores (< {passMark}): {failingCount}");
        }

        // Method 1: Reads exam scores into the array
        void ReadResults(int[] results)
        {
            Console.WriteLine("Enter the exam scores (0 to 100):");
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write($"Score for student {i + 1}: ");
                results[i] = int.Parse(Console.ReadLine());

                // Validate that the score is between 0 and 100
                while (results[i] < 0 || results[i] > 100)
                {
                    Console.Write("Invalid score. Please enter a value between 0 and 100: ");
                    results[i] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Method 2: Returns the number of passing scores (>= passMark)
        int CountPassingScores(int[] results, int passMark)
        {
            int count = 0;
            foreach (int score in results)
            {
                if (score >= passMark)
                {
                    count++;
                }
            }
            return count;
        }

        // Method 3: Returns the number of failing scores (< passMark)
        int CountFailingScores(int[] results, int passMark)
        {
            int count = 0;
            foreach (int score in results)
            {
                if (score < passMark)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
