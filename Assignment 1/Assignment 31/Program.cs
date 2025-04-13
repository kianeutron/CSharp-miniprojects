
namespace Assignment31
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter a year
            Console.WriteLine("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            // Call the DisplayPrimeYearCheck method to check if the year is prime
            DisplayPrimeYearCheck(year);
        }

        // Method to check if a given year is a prime year
        bool IsPrimeYear(int year)
        {
            if (year <= 1) // 1 and negative numbers are not prime
            {
                return false;
            }

            // Check divisibility from 2 to the square root of the year
            for (int i = 2; i * i <= year; i++)
            {
                if (year % i == 0)
                {
                    return false; // Not a prime year
                }
            }

            return true; // Prime year
        }

        // Method to display if the given year is prime or not
        void DisplayPrimeYearCheck(int year)
        {
            if (IsPrimeYear(year))
            {
                Console.WriteLine($"The year {year} is a prime year.");
            }
            else
            {
                Console.WriteLine($"The year {year} is not a prime year.");
            }
        }
    }
}
