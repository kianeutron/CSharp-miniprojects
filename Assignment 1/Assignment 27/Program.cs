
namespace Assignment27
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            // Call the CheckSignAndParity method to check and display the result
            CheckSignAndParity(number);
        }

        // Method to check if the number is positive, negative, or zero
        // Also checks if the number is odd or even
        void CheckSignAndParity(int number)
        {
            // Check if the number is positive, negative, or zero
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

            // Check if the number is odd or even
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
