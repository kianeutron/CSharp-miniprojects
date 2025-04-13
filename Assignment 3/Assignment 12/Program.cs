namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Ask the user for a grade
            Console.Write("Enter the grade: ");
            int grade = int.Parse(Console.ReadLine());

            // Step 2: Use ClassifyGrade to classify the grade and display the result
            string classification = ClassifyGrade(grade);

            Console.WriteLine($"The grade classification is: {classification}");
        }

        // Method 1: Classifies the grade into "Fail", "Pass", or "Excellent"
        string ClassifyGrade(int grade)
        {
            if (grade < 50)
            {
                return "Fail";
            }
            else if (grade >= 50 && grade < 75)
            {
                return "Pass";
            }
            else
            {
                return "Excellent";
            }
        }
    }
}
