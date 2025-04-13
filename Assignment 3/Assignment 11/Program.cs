namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user to enter three numbers
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            // Step 2: Call CalculateAverage to compute the average and display it
            double average = CalculateAverage(num1, num2, num3);

            Console.WriteLine($"The average of the three numbers is: {average}");
        }

        // Method 1: Returns the average of three numbers
        double CalculateAverage(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) / 3.0;
        }
    }
}
