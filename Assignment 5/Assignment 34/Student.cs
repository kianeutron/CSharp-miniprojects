using System;
using System.Linq;

namespace Assignment34
{
    class Student
    {
        // Private field for Scores (array of integers)
        private int[] _scores;

        // Constructor to initialize the Scores array
        public Student(int[] scores)
        {
            _scores = scores ?? throw new ArgumentNullException(nameof(scores), "Scores cannot be null.");
        }

        // Property to get the Scores array
        public int[] Scores
        {
            get { return _scores; }
        }

        // Calculated property for AverageScore
        public double AverageScore
        {
            get
            {
                return _scores.Average();
            }
        }

        // Method to display student's information
        public void DisplayInfo()
        {
            Console.WriteLine("Student Scores: " + string.Join(", ", _scores));
            Console.WriteLine($"Average Score: {AverageScore:F2}");
        }
    }
}
