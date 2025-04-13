
namespace Assignment39
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

            bool isHappy = IsHappy(number);

            if (isHappy)
            {
                Console.WriteLine(number + " is a happy number.");
            }
            else
            {
                Console.WriteLine(number + " is not a happy number.");
            }
        }

        // Method to determine if a number is a happy number
        bool IsHappy(int number)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (number != 1 && !seenNumbers.Contains(number))
            {
                seenNumbers.Add(number);
                number = GetSumOfSquaresOfDigits(number);
            }

            return number == 1;
        }

        // Method to calculate the sum of squares of the digits of a number
        int GetSumOfSquaresOfDigits(int number)
        {
            int sum = 0;
            
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }

            return sum;
        }
    }
}
