namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.Write("Enter the student's score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            string grade = GetGrade(score);

            Console.WriteLine($"\nStudent Score: {score}");
            Console.WriteLine($"Assigned Grade: {grade}");
        }

        string GetGrade(int score)
        {
            if (score >= 90 && score <= 100)
                return "A";
            else if (score >= 80 && score <= 89)
                return "B";
            else if (score >= 70 && score <= 79)
                return "C";
            else if (score >= 60 && score <= 69)
                return "D";
            else
                return "F";
        }
    }
}
