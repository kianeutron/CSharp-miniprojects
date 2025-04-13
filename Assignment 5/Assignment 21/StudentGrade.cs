namespace Assignment21
{
    public class StudentGrade
    {
        // Properties for StudentName, AssignmentScore, and ExamScore
        public string StudentName { get; set; }
        public double AssignmentScore { get; set; }
        public double ExamScore { get; set; }

        // Calculated property for FinalGrade
        public double FinalGrade
        {
            get { return (AssignmentScore + ExamScore) / 2; }
        }

        // Constructor to initialize the student data
        public StudentGrade(string studentName, double assignmentScore, double examScore)
        {
            StudentName = studentName;
            AssignmentScore = assignmentScore;
            ExamScore = examScore;
        }

        // Method to display student's information and final grade
        public void DisplayGradeInfo()
        {
            Console.WriteLine($"Student: {StudentName}");
            Console.WriteLine($"Assignment Score: {AssignmentScore}");
            Console.WriteLine($"Exam Score: {ExamScore}");
            Console.WriteLine($"Final Grade: {FinalGrade:F2}"); // Format to 2 decimal places
        }
    }
}
