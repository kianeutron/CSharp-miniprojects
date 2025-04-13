using System;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Student student = ReadStudent();
            student.DisplayStudentInfo();
        }

        static Student ReadStudent()
        {
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter total credits: ");
            int totalCredits = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            return new Student(name, totalCredits, gpa);
        }
    }
}
