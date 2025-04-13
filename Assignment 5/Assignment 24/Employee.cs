namespace Assignment24
{
    public class Employee
    {
        // Properties
        public string EmployeeName { get; }
        public double Salary { get; set; }
        private double BonusPercentage { get; set; }  // Private property to hold bonus percentage

        // Constructor to initialize properties
        public Employee(string employeeName, double salary, double bonusPercentage)
        {
            EmployeeName = employeeName;
            Salary = salary;
            BonusPercentage = bonusPercentage;
        }

        // Method to calculate bonus based on salary and bonus percentage
        public double CalculateBonus()
        {
            return Salary * (BonusPercentage / 100);
        }

        // Method to display employee information including bonus
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee: {EmployeeName}\nSalary: ${Salary:F2}\nBonus: ${CalculateBonus():F2}");
        }
    }
}
