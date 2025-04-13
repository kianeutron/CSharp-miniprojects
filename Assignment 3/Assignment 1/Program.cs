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
            // Prompt the user to enter the number of employees
            Console.Write("Enter the number of employees: ");
            int employeeCount = int.Parse(Console.ReadLine());

            // Create an array to store the ratings
            int[] ratings = new int[employeeCount];

            // Fill the array with performance ratings using ReadRatings
            ReadRatings(ratings);

            // For each employee, ask for the base salary, calculate the bonus, and display the result
            for (int i = 0; i < employeeCount; i++)
            {
                Console.Write($"Enter the base salary for employee {i + 1}: ");
                double baseSalary = double.Parse(Console.ReadLine());

                // Calculate the bonus
                double bonus = CalculateBonus(baseSalary, ratings[i]);

                // Display the result
                Console.WriteLine($"Employee {i + 1}: Base Salary = {baseSalary:C}, Rating = {ratings[i]}, Bonus = {bonus:C}\n");
            }
        }

        // Method to read employee performance ratings into an array
        void ReadRatings(int[] ratings)
        {
            Console.WriteLine("Enter performance ratings (1 to 10):");
            for (int i = 0; i < ratings.Length; i++)
            {
                Console.Write($"Rating for employee {i + 1}: ");
                ratings[i] = int.Parse(Console.ReadLine());

                // Validate that the rating is between 1 and 10
                while (ratings[i] < 1 || ratings[i] > 10)
                {
                    Console.Write("Invalid rating. Please enter a value between 1 and 10: ");
                    ratings[i] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Method to calculate the bonus amount based on the base salary and rating
        double CalculateBonus(double baseSalary, int rating)
        {
            if (rating >= 9)
            {
                return baseSalary * 0.2; // 20% bonus
            }
            else if (rating >= 7)
            {
                return baseSalary * 0.1; // 10% bonus
            }
            else
            {
                return 0; // No bonus
            }
        }
    }
}
