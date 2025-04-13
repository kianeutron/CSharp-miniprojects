
namespace Assignment38
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            List<int> primeFactors = GetPrimeFactors(number);

            Console.WriteLine("Prime factors of " + number + " are: ");
            foreach (int factor in primeFactors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine();
        }

        // Method to get the prime factors of a number
        List<int> GetPrimeFactors(int number)
        {
            List<int> primeFactors = new List<int>();
            
            // First, divide by 2 until the number is odd
            while (number % 2 == 0)
            {
                primeFactors.Add(2);
                number /= 2;
            }

            // Check for all odd numbers starting from 3
            for (int i = 3; i * i <= number; i += 2)
            {
                while (number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }

            // If the number is still greater than 2, it must be prime
            if (number > 2)
            {
                primeFactors.Add(number);
            }

            return primeFactors;
        }
    }
}
