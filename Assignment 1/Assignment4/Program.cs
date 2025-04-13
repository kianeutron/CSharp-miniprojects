namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the employee's base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter the employee's years of experience: ");
            int experienceYears = int.Parse(Console.ReadLine());

            double bonusPercentage = GetExperienceLevel(experienceYears);
            double bonusAmount = CalculateBonusAmount(baseSalary, bonusPercentage);
            double totalSalary = CalculateSalaryWithBonus(baseSalary, bonusAmount);

            Console.WriteLine($"\nBase Salary: ${baseSalary}");
            Console.WriteLine($"Experience Years: {experienceYears}");
            Console.WriteLine($"Bonus Percentage: {bonusPercentage}%");
            Console.WriteLine($"Bonus Amount: ${bonusAmount}");
            Console.WriteLine($"Total Salary: ${totalSalary}");
        }

        double GetExperienceLevel(int years)
        {
            if (years < 1)
                return 0; // No bonus for less than 1 year
            else if (years >= 1 && years < 5)
                return 10; // 10% bonus
            else
                return 20; // 20% bonus for 5+ years
        }

        double CalculateBonusAmount(double baseSalary, double bonusPercentage)
        {
            return baseSalary * (bonusPercentage / 100);
        }

        double CalculateSalaryWithBonus(double baseSalary, double bonusAmount)
        {
            return baseSalary + bonusAmount;
        }
    }
}
