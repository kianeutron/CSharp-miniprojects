using System;

namespace Assignment37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a quiz with space for 3 questions
            Quiz quiz = new Quiz(3);

            // Add questions to the quiz
            quiz.AddQuestion(new Question("What is the capital of France?", 
                new string[] { "Berlin", "Madrid", "Paris", "Rome" }, 2));

            quiz.AddQuestion(new Question("Which of the following is a C# data type?", 
                new string[] { "int", "double", "char", "All of the above" }, 3));

            quiz.AddQuestion(new Question("Which planet is known as the Red Planet?", 
                new string[] { "Earth", "Mars", "Jupiter", "Venus" }, 1));

            // Start the quiz
            quiz.TakeQuiz();

            // Display the final score and results
            quiz.DisplayResults();
        }
    }
}
