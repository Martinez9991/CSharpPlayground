namespace QuizAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
                {
                    new Question("What is the capital of Germany?", //Question Text
                    new string[] {"Paris","Berlin","London","Madrid"}, // Answers Array
                    1), // CorrectAnswerIndex
                    new Question("What is 2+2?", //Question Text
                    new string[] {"3","4","5","6"}, // Answers Array
                    1),// CorrectAnswerIndex
                    new Question("Who rode 'Hammlet'?", //Question Text
                    new string[] {"Goethe","Austin", "Shakespeare", "Dickens"}, // Answers Array
                    2)
                };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
