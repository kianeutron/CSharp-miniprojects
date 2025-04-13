namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the total purchase amount: ");
            double totalAmount = double.Parse(Console.ReadLine());

            int taxPercentage = GetTaxPercentage(totalAmount);
            double taxAmount = CalculateTaxAmount(totalAmount, taxPercentage);
            double finalAmount = ApplyTax(totalAmount, taxAmount);

            Console.WriteLine($"Tax Percentage: {taxPercentage}%");
            Console.WriteLine($"Tax Amount: {taxAmount:C}");
            Console.WriteLine($"Final Amount to Pay (Including Tax): {finalAmount:C}");
        }

        int GetTaxPercentage(double totalAmount)
        {
            if (totalAmount < 100)
                return 5;   // Basic tax
            else if (totalAmount < 300)
                return 10;  // Moderate tax
            else if (totalAmount < 500)
                return 15;  // High tax
            else
                return 20;  // Luxury tax
        }

        double CalculateTaxAmount(double totalAmount, int taxPercentage)
        {
            return (totalAmount * taxPercentage) / 100;
        }

        double ApplyTax(double totalAmount, double taxAmount)
        {
            return totalAmount + taxAmount;
        }
    }
}
