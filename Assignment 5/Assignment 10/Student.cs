namespace Assignment10
{
    internal class Student
    {
        public string Name { get; private set; }
        public int TotalCredits { get; set; }
        public double GPA { get; set; }

        public Student(string name, int totalCredits, double gpa)
        {
            Name = name;
            TotalCredits = totalCredits;
            GPA = gpa;
        }

        public string GPAStatus
        {
            get { return GPA < 2.0 ? "At Risk" : "Good"; }
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Total Credits: {TotalCredits}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine($"GPA Status: {GPAStatus}");
        }
    }
}
