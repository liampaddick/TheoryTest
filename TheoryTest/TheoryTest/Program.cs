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

            Question[] questionArray = new Question[50];
            Answer[] answerArray = new Answer[200];

            //init answers before questions
            answerArray = initAnswers();
            questionArray = initQuestions();
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

        public static int questionCount;

        public Question(string questionText, Answer answer1, Answer answer2, Answer answer3, Answer answer4)
        {
            localID = questionCount;
            localQuestionText = questionText;
            localPossibleAnswerArray[0] = answer1;
            localPossibleAnswerArray[1] = answer2;
            localPossibleAnswerArray[2] = answer3;
            localPossibleAnswerArray[3] = answer4;

            questionCount++;
        }

        public int GetQuestionID()
        {
            return localID;
        }

        public string GetQuestionText()
        {
            return localQuestionText;
        }

        public Answer[] GetPossibleAnswerArray()
        {
            return localPossibleAnswerArray;
        }
    }

    class Answer
    {
        int localLinkedQuestionID;
        int localID;
        string localAnswerText;
        bool localCorrectAnswer;

        public static int answerCount;

        public Answer(int linkedQuestionID, string answerText, bool correctAnswer)
        {
            localLinkedQuestionID = linkedQuestionID;
            localID = answerCount;
            localAnswerText = answerText;
            localCorrectAnswer = correctAnswer;

            answerCount++;
        }

        public int GetLinkedQuestionID()
        {
            return localLinkedQuestionID;
        }

        public int GetAnswerID()
        {
            return localID;
        }

        public string GetAnswerText()
        {
            return localAnswerText;
        }

        public bool GetCorrectAnswer()
        {
            return localCorrectAnswer;
        }

    }
}
