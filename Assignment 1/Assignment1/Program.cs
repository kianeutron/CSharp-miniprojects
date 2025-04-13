namespace Assignment1
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

            int discountPercentage = GetDiscountPercentage(totalAmount);
            double discountAmount = CalculateDiscountAmount(totalAmount, discountPercentage);
            double finalAmount = ApplyDiscount(totalAmount, discountAmount);

            Console.WriteLine($"Discount Percentage: {discountPercentage}%");
            Console.WriteLine($"Discount Amount: {discountAmount:C}");
            Console.WriteLine($"Final Amount to Pay: {finalAmount:C}");
        }

        int GetDiscountPercentage(double totalAmount)
        {
            if (totalAmount < 100)
                return 0;
            else if (totalAmount >= 100 && totalAmount < 300)
                return 10;
            else if (totalAmount >= 300 && totalAmount < 500)
                return 15;
            else
                return 20;
        }

        double CalculateDiscountAmount(double totalAmount, int discountPercentage)
        {
            return (totalAmount * discountPercentage) / 100;
        }

        double ApplyDiscount(double totalAmount, double discountAmount)
        {
            return totalAmount - discountAmount;
        }
    }
}
