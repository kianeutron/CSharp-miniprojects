namespace Assignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example input array
            int[] numbers = { 10, 11, 13, 15, 17, 18 };
            
            // Calling the method to get the sum of primes
            int sum = SumOfPrimes(numbers);

            // Display the result
            Console.WriteLine($"Sum of primes: {sum}");
        }

        // Method 1: Check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;  // Numbers less than or equal to 1 are not prime

            for (int i = 2; i <= Math.Sqrt(number); i++)  // Check divisibility up to the square root of the number
            {
                if (number % i == 0)
                    return false;  // If divisible by any number, it's not prime
            }
            return true;  // If no divisors are found, it's prime
        }

        // Method 2: Sum of prime numbers in the array
        static int SumOfPrimes(int[] numbers)
        {
            int sum = 0;

            foreach (var num in numbers)
            {
                if (IsPrime(num))
                {
                    sum += num;  // Add prime numbers to the sum
                }
            }

            return sum;  // Return the total sum of prime numbers
        }
    }
}
