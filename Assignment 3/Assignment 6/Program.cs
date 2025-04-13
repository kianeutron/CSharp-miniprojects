namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user for the start and end of the range
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            // Step 2: Use GeneratePrimesInRange to get all prime numbers in the range
            int[] primes = GeneratePrimesInRange(start, end);

            // Step 3: Display the prime numbers or a message if none exist
            if (primes.Length > 0)
            {
                Console.WriteLine("\nPrime numbers in the range:");
                foreach (int prime in primes)
                {
                    Console.Write(prime + " ");
                }
            }
            else
            {
                Console.WriteLine($"\nNo prime numbers found in the range [{start}, {end}].");
            }
        }

        // Method 1: Checks if a number is a prime number
        bool IsPrime(int number)
        {
            if (number < 2) return false; // Prime numbers are greater than 1

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Method 2: Generates and returns an array of all prime numbers between start and end (inclusive)
        int[] GeneratePrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray(); // Convert List to Array
        }
    }
}
