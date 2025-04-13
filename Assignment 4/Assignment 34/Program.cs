using System;

namespace Assignment34
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter the student's name
            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();

            // Prompt user to enter the number of grades
            Console.Write("Enter the number of grades: ");
            int numGrades = Convert.ToInt32(Console.ReadLine());

            // Create an array to store the grades
            int[] grades = new int[numGrades];

            // Prompt user to enter grades
            for (int i = 0; i < numGrades; i++)
            {
                Console.Write($"Enter grade #{i + 1}: ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Create a student object with the entered name and grades
            Student student = new Student(studentName, grades);

            // Display the student's grades
            student.DisplayGrades();

            // Calculate and display the average of the grades
            double average = student.CalculateAverage();
            Console.WriteLine($"Average grade for {studentName}: {average:F2}");
        }
    }
}
