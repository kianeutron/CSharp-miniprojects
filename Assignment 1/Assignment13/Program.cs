namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Currency Converter");
            Console.WriteLine("1: Convert USD to EUR");
            Console.WriteLine("2: Convert EUR to USD");

            // Get user input for conversion choice
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());

            // Ask for the amount to convert based on the conversion choice
            if (choice == 1)
            {
                Console.Write("Enter amount in USD: ");
                double usdAmount = double.Parse(Console.ReadLine());
                double eurAmount = ConvertUsdToEur(usdAmount);
                Console.WriteLine($"{usdAmount} USD = {eurAmount} EUR");
            }
            else if (choice == 2)
            {
                Console.Write("Enter amount in EUR: ");
                double eurAmount = double.Parse(Console.ReadLine());
                double usdAmount = ConvertEurToUsd(eurAmount);
                Console.WriteLine($"{eurAmount} EUR = {usdAmount} USD");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter either 1 or 2.");
            }
        }

        // Method to convert USD to EUR (using exchange rate of 1 USD = 0.85 EUR as an example)
        double ConvertUsdToEur(double usdAmount)
        {
            return usdAmount * 0.85;
        }

        // Method to convert EUR to USD (using exchange rate of 1 EUR = 1.18 USD as an example)
        double ConvertEurToUsd(double eurAmount)
        {
            return eurAmount * 1.18;
        }
    }
}
