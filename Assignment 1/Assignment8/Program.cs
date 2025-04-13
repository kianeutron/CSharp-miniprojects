namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter your monthly income: $");
            double income = double.Parse(Console.ReadLine());

            string eligibility = GetLoanEligibility(income);
            double interestRate = CalculateLoanInterest(income);

            DisplayLoanDetails(income, eligibility, interestRate);
        }

        string GetLoanEligibility(double income)
        {
            if (income < 3000)
                return "Not eligible";
            else if (income >= 3000 && income < 6000)
                return "Eligible with 5% interest";
            else
                return "Eligible with 3% interest";
        }

        double CalculateLoanInterest(double income)
        {
            if (income >= 6000)
                return 3.0; // 3% interest
            else if (income >= 3000)
                return 5.0; // 5% interest
            else
                return 0.0; // No interest since not eligible
        }

        void DisplayLoanDetails(double income, string eligibility, double interestRate)
        {
            Console.WriteLine($"\nIncome: ${income:0.00}");
            Console.WriteLine($"Loan Status: {eligibility}");
            if (interestRate > 0)
                Console.WriteLine($"Interest Rate: {interestRate}%");
        }
    }
}
