namespace Assignment20
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Prompt user for a score
            Console.WriteLine("Enter your score (0-100):");
            int score;

            // Validate user input
            if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
            {
                // Call GetGradeFeedback to determine grade and feedback
                string feedback = GetGradeFeedback(score);

                // Display the feedback
                Console.WriteLine($"Score: {score} - {feedback}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a score between 0 and 100.");
            }
        }

        string GetGradeFeedback(int score)
        {
            // Determine the grade and feedback using nested if-else
            if (score >= 90)
            {
                return "A: Excellent work!";
            }
            else if (score >= 80)
            {
                return "B: Good job, but there’s room for improvement.";
            }
            else if (score >= 70)
            {
                return "C: You passed, but consider reviewing the material.";
            }
            else if (score >= 60)
            {
                return "D: Barely passed, you should work harder.";
            }
            else
            {
                return "F: Failed, please seek help.";
            }
        }
    }
}
