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
            Console.Write("Enter the total order amount: $");
            double orderAmount = double.Parse(Console.ReadLine());

            double shippingCost = GetShippingCost(orderAmount);
            DisplayShippingCost(orderAmount, shippingCost);
        }

        double GetShippingCost(double orderAmount)
        {
            if (orderAmount < 100)
                return 10.0; // $10 shipping fee
            else if (orderAmount >= 100 && orderAmount < 200)
                return 5.0; // $5 shipping fee
            else
                return 0.0; // Free shipping
        }

        void DisplayShippingCost(double orderAmount, double shippingCost)
        {
            Console.WriteLine($"\nFor an order amount of ${orderAmount:0.00}, the shipping cost is ${shippingCost:0.00}.");
        }
    }
}
