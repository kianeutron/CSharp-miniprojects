namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter your total purchase amount: $");
            double purchaseAmount = double.Parse(Console.ReadLine());

            string membershipLevel = GetMembershipLevel(purchaseAmount);

            DisplayMembershipLevel(purchaseAmount, membershipLevel);
        }

        string GetMembershipLevel(double amount)
        {
            if (amount < 100)
                return "Bronze";
            else if (amount >= 100 && amount < 500)
                return "Silver";
            else
                return "Gold";
        }

        void DisplayMembershipLevel(double amount, string membershipLevel)
        {
            Console.WriteLine($"\nTotal Purchase Amount: ${amount:0.00}");
            Console.WriteLine($"Membership Level: {membershipLevel}");
        }
    }
}
