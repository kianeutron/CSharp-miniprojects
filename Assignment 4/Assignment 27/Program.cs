namespace Assignment27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input values: Principal, Interest Rate, and Number of Months
            double principal = 10000;
            double annualInterestRate = 5; // 5% annual interest
            int months = 36;

            // Calculate monthly payment
            double monthlyPayment = CalculateMonthlyPayment(principal, annualInterestRate, months);

            // Display the result
            Console.WriteLine($"Monthly Payment: {monthlyPayment:F2}");
        }

        // Method 1: Calculate Monthly Payment
        static double CalculateMonthlyPayment(double principal, double annualInterestRate, int months)
        {
            // Convert annual interest rate to monthly interest rate
            double monthlyRate = (annualInterestRate / 100) / 12;

            // Calculate monthly payment using the formula
            double payment = principal * monthlyRate * Math.Pow(1 + monthlyRate, months) /
                             (Math.Pow(1 + monthlyRate, months) - 1);

            return payment;
        }
    }
}
