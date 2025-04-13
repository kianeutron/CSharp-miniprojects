namespace Assignment37
{
    public class Question
    {
        // Properties for question text, possible options, and correct answer index
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }

        // Constructor to initialize the question and possible answers
        public Question(string questionText, string[] options, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        // Method to display the question and options
        public void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }

        // Method to check if the given answer is correct
        public bool IsAnswerCorrect(int answerIndex)
        {
            return answerIndex == CorrectAnswerIndex;
        }
    }
}
