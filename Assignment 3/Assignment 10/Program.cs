namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user to enter two numbers
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Step 2: Use GetLargerNumber to find and display the larger number
            int largerNumber = GetLargerNumber(num1, num2);

            Console.WriteLine($"The larger number is: {largerNumber}");
        }

        // Method 1: Returns the larger number between num1 and num2
        int GetLargerNumber(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
