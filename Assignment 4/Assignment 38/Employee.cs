namespace Assignment38
{
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Salary { get; set; }

        // Constructor to initialize Name, ID, and Salary
        public Employee(string name, int id, double salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Salary: {Salary:C}");
        }
    }
}
