namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter your total budget amount: $");
            double totalBudget = double.Parse(Console.ReadLine());

            // Call the AllocateBudget method and get the allocated amounts for each category
            double foodBudget = GetCategoryBudget(totalBudget, 30);
            double housingBudget = GetCategoryBudget(totalBudget, 40);
            double entertainmentBudget = GetCategoryBudget(totalBudget, 15);
            double miscBudget = GetCategoryBudget(totalBudget, 15);

            // Display the results
            DisplayBudgetAllocation(totalBudget, foodBudget, housingBudget, entertainmentBudget, miscBudget);
        }

        // Method to calculate the budget allocation for each category
        double GetCategoryBudget(double totalBudget, double percentage)
        {
            return totalBudget * (percentage / 100);
        }

        // Method to display the budget allocation for each category
        void DisplayBudgetAllocation(double totalBudget, double food, double housing, double entertainment, double misc)
        {
            Console.WriteLine($"\nTotal Budget: ${totalBudget:0.00}");
            Console.WriteLine($"Food: ${food:0.00}");
            Console.WriteLine($"Housing: ${housing:0.00}");
            Console.WriteLine($"Entertainment: ${entertainment:0.00}");
            Console.WriteLine($"Miscellaneous: ${misc:0.00}");
        }
    }
}
