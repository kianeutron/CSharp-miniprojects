namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Repeatedly prompt the user to enter a number
            while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                int number = int.Parse(Console.ReadLine());

                // Stop the loop if the number is 0 or negative
                if (number <= 0)
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                // Check if the number is even or odd and display the result
                if (IsEven(number))
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }
            }
        }

        // Method 1: Checks if a number is even
        bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
