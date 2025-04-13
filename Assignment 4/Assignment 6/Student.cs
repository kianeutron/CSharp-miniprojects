namespace Assignment6
{
    using System;

    public class Student
    {
        // Fields for student name and grade
        public string Name { get; set; }
        public double Grade { get; private set; }

        // Constructor to initialize the student with a name
        public Student(string name)
        {
            Name = name;
            Grade = 0; // Default grade is 0
        }

        // Method to assign a grade to the student
        public void AssignGrade(double grade)
        {
            if (grade >= 0 && grade <= 100) 
            {
                Grade = grade;
                Console.WriteLine($"{Name}'s grade has been assigned: {Grade}");
            }
            else
            {
                Console.WriteLine("Invalid grade. The grade must be between 0 and 100.");
            }
        }

        // Method to display the student's name and grade
        public void DisplayGrade()
        {
            Console.WriteLine($"{Name}'s grade: {Grade}");
        }
    }
}
