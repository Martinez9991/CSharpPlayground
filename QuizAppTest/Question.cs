using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Question
    {
        public string QuestionText { get; }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        //Method to check if the answer is correct
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }

    }
}
