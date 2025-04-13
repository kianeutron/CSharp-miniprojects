namespace Assignment37
{
    public class Quiz
    {
        // Array of questions and a variable to store the score
        private Question[] questions;
        private int score;
        private int currentQuestionIndex;

        // Constructor to initialize the quiz with a set number of questions
        public Quiz(int numberOfQuestions)
        {
            questions = new Question[numberOfQuestions];
            score = 0;
            currentQuestionIndex = 0;
        }

        // Method to add a question to the quiz
        public void AddQuestion(Question question)
        {
            if (currentQuestionIndex < questions.Length)
            {
                questions[currentQuestionIndex] = question;
                currentQuestionIndex++;
            }
            else
            {
                Console.WriteLine("Quiz is full! Cannot add more questions.");
            }
        }

        // Method to administer the quiz by asking each question and collecting answers
        public void TakeQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!\n");

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
                questions[i].DisplayQuestion();

                int answer = 0;
                while (true)
                {
                    Console.Write("Enter the number of your answer: ");
                    if (int.TryParse(Console.ReadLine(), out answer) && answer >= 1 && answer <= questions[i].Options.Length)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please choose a valid answer number.");
                    }
                }

                // Check if the answer is correct and update score
                if (questions[i].IsAnswerCorrect(answer - 1))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer was: {questions[i].Options[questions[i].CorrectAnswerIndex]}.");
                }
            }
        }

        // Method to display the results
        public void DisplayResults()
        {
            Console.WriteLine($"\nYour score: {score}/{questions.Length}");
            Console.WriteLine(score >= questions.Length / 2 ? "You passed the quiz!" : "You did not pass. Try again!");
        }
    }
}
