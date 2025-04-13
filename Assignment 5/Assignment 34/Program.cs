using System;

namespace Assignment34
{
    class Program
    {
        // Main method to run the application
        static void Main(string[] args)
        {
            Start();
        }

        // Start method to create and manage a student
        static void Start()
        {
            // Example scores array
            int[] studentScores = { 85, 90, 78, 92, 88 };

            // Create a Student object
            Student student = new Student(studentScores);

            // Display the student's scores and average score
            student.DisplayInfo();
        }
    }
}
