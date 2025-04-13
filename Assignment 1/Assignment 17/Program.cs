namespace Assignment17
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Prompt the user for three integers
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            // Find the maximum of the three numbers
            int max = FindMax(num1, num2, num3);

            // Display the result
            Console.WriteLine($"The maximum number is: {max}");
        }

        int FindMax(int num1, int num2, int num3)
        {
            // Compare the three numbers and return the maximum
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
