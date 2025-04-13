using System;

namespace Assignment21
{
    class Program
    {
        // Start method to run the program
        static void Start()
        {
            // Create a new StudentGrade object with sample data
            StudentGrade student = new StudentGrade("John Doe", 85, 90);

            // Display the student's grading details
            student.DisplayGradeInfo();
        }

        // Main method to call the Start method
        static void Main(string[] args)
        {
            Start();
        }
    }
}
