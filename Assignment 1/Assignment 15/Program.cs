namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                CheckNumber(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        void CheckNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
