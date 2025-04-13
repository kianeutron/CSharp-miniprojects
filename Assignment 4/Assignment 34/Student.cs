namespace Assignment34
{
    public class Student
    {
        // Fields for student name and grades
        public string Name { get; set; }
        public int[] Grades { get; set; }

        // Constructor to initialize the student with name and grades
        public Student(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        // Method to calculate the average grade
        public double CalculateAverage()
        {
            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return (double)sum / Grades.Length;
        }

        // Method to display all grades
        public void DisplayGrades()
        {
            Console.WriteLine($"Grades for {Name}:");
            foreach (int grade in Grades)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();
        }
    }
}
