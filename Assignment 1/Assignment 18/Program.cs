namespace Assignment18
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

            // Check if the entered year is a leap year
            bool isLeapYear = IsLeapYear(year);

            // Display the result
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        bool IsLeapYear(int year)
        {
            // A year is a leap year if it is divisible by 4 and:
            // Not divisible by 100 or divisible by 400
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
