using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheoryTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static Question[] initQuestions()
        {
            Question[] tempQuestionArray = new Question[50];
            return tempQuestionArray;
        }

        static Answer[] initAnswers()
        {
            Answer[] tempAnswerArray = new Answer[200];
            return tempAnswerArray;
        }
    }

    class Question
    {
        int localID;
        string localQuestionText;
        Answer[] localPossibleAnswerArray = new Answer[4];

        public Question(int id, string questionText, Answer answer1, Answer answer2, Answer answer3, Answer answer4)
        {
            localID = id;
            localQuestionText = questionText;
            localPossibleAnswerArray[0] = answer1;
            localPossibleAnswerArray[1] = answer2;
            localPossibleAnswerArray[2] = answer3;
            localPossibleAnswerArray[3] = answer4;
        }
    }

    class Answer
    {
        int localLinkedQuestionID;
        int localAnswerID;
        string localAnswerText;
        bool localCorrectAnswer;

        public Answer(int linkedQuestionID, int answerID, string answerText, bool correctAnswer)
        {
            localLinkedQuestionID = linkedQuestionID;
            localAnswerID = answerID;
            localAnswerText = answerText;
            localCorrectAnswer = correctAnswer;
        }
    }
}
