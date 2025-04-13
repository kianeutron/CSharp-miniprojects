namespace Assignment2
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        // Fields
        public string Name { get; set; }
        public int StudentLimit { get; set; }
        public List<string> EnrolledStudents { get; set; }

        // Constructor
        public Course(string name, int studentLimit)
        {
            Name = name;
            StudentLimit = studentLimit;
            EnrolledStudents = new List<string>();
        }

        // Add student to the course if the limit is not reached
        public void AddStudent(string studentName)
        {
            if (EnrolledStudents.Count < StudentLimit)
            {
                EnrolledStudents.Add(studentName);
                Console.WriteLine($"Student {studentName} added to {Name}.");
            }
            else
            {
                Console.WriteLine($"Cannot add student {studentName}. Course limit reached.");
            }
        }

        // Remove student from the course
        public void RemoveStudent(string studentName)
        {
            if (EnrolledStudents.Contains(studentName))
            {
                EnrolledStudents.Remove(studentName);
                Console.WriteLine($"Student {studentName} removed from {Name}.");
            }
            else
            {
                Console.WriteLine($"Student {studentName} is not enrolled in the course.");
            }
        }

        // Display course details: name, student limit, and enrolled students
        public void DisplayDetails()
        {
            Console.WriteLine($"\nCourse Name: {Name}");
            Console.WriteLine($"Student Limit: {StudentLimit}");
            Console.WriteLine("Enrolled Students:");

            if (EnrolledStudents.Count == 0)
            {
                Console.WriteLine("No students enrolled yet.");
            }
            else
            {
                foreach (var student in EnrolledStudents)
                {
                    Console.WriteLine($"- {student}");
                }
            }
        }
    }
}
