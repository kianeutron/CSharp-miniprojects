namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create an array to store the bills
            double[] bills = new double[10];

            // Step 2: Use ReadBills to populate the array
            ReadBills(bills);

            // Step 3: Ask the user for a threshold amount
            Console.Write("Enter the threshold amount: ");
            double threshold = double.Parse(Console.ReadLine());

            // Step 4: Use CountHighBills to calculate the number of high bills
            int highBillCount = CountHighBills(bills, threshold);

            // Step 5: Display the results
            Console.WriteLine($"\nNumber of customers owing more than {threshold}: {highBillCount}");
        }

        // Method 1: Reads the bill amounts into the array
        void ReadBills(double[] bills)
        {
            Console.WriteLine("Enter the bill amounts for 10 customers:");
            for (int i = 0; i < bills.Length; i++)
            {
                Console.Write($"Bill for customer {i + 1}: ");
                bills[i] = double.Parse(Console.ReadLine());

                // Validate that the bill amount is non-negative
                while (bills[i] < 0)
                {
                    Console.Write("Invalid amount. Please enter a non-negative value: ");
                    bills[i] = double.Parse(Console.ReadLine());
                }
            }
        }

        // Method 2: Counts the number of customers with bills greater than the threshold
        int CountHighBills(double[] bills, double threshold)
        {
            int count = 0;
            foreach (double bill in bills)
            {
                if (bill > threshold)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
