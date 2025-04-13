namespace Assignment16
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Enter the first number:");
            if (!double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.WriteLine("Enter the second number:");
            if (!double.TryParse(Console.ReadLine(), out double number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.WriteLine("Choose an operation (+, -, *, /):");
            string operation = Console.ReadLine();

            double result = CalculateResult(number1, number2, operation);

            if (!double.IsNaN(result))
            {
                Console.WriteLine($"Result: {result}");
            }
        }

        double CalculateResult(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return Add(number1, number2);
                case "-":
                    return Subtract(number1, number2);
                case "*":
                    return Multiply(number1, number2);
                case "/":
                    return Divide(number1, number2);
                default:
                    Console.WriteLine("Invalid operation.");
                    return double.NaN; // Return "Not a Number" for invalid cases
            }
        }

        double Add(double a, double b)
        {
            return a + b;
        }

        double Subtract(double a, double b)
        {
            return a - b;
        }

        double Multiply(double a, double b)
        {
            return a * b;
        }

        double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return double.NaN; // Handle division by zero
            }
            return a / b;
        }
    }
}
