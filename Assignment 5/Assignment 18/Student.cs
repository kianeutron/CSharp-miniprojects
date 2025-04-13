namespace Assignment18
{
    class Student
    {
        // Properties
        public string Name { get; private set; }  // Readonly Name
        public int Age { get; private set; }     // Readonly Age after initialization
        public double GPA { get; private set; }   // GPA with private setter

        // Constructor to initialize properties
        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"GPA: {GPA:F2}");
        }
    }
}
