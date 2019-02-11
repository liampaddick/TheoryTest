using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheoryTest
{
    public partial class Form1 : Form
    {

        Question[] questionArray = new Question[50];
        Answer[] answerArray = new Answer[200];

        Question[] randomQuestionArray = new Question[50];

        public Form1()
        {
            InitializeComponent();

            //init answers before questionsS
            answerArray = initAnswers();
            questionArray = initQuestions(answerArray);
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            MainMenuText.Text = "start button pressed";
            //get 3 random questions from bank
            randomQuestionArray = PickQuestions(questionArray, 5);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Question[] initQuestions(Answer[] passedAnswerArray)
        {
            int arraySize = 50;

            int answer1Index = 0;
            int answer2Index = 0;
            int answer3Index = 0;
            int answer4Index = 0;

            int baseIndex = 0;

            string questionText;


            Answer answer1 = passedAnswerArray[0];
            Answer answer2 = passedAnswerArray[0];
            Answer answer3 = passedAnswerArray[0];
            Answer answer4 = passedAnswerArray[0];


            Question[] tempQuestionArray = new Question[arraySize];

            //this loop will automate the process of adding meaningful test values to the question array. The data for each question would need to be manually added for the actual questions or a JSON file would need to be used
            for (int i = 0; i < arraySize; i++)
            {
                questionText = "Question " + i;

                if (i == 0)
                {
                    baseIndex = i;
                }

                answer1Index = baseIndex;
                answer2Index = baseIndex + 1;
                answer3Index = baseIndex + 2;
                answer4Index = baseIndex + 3;

                answer1 = passedAnswerArray[answer1Index];
                answer2 = passedAnswerArray[answer2Index];
                answer3 = passedAnswerArray[answer3Index];
                answer4 = passedAnswerArray[answer4Index];

                Question tempQuestion = new Question(questionText, answer1, answer2, answer3, answer4);

                tempQuestionArray[i] = tempQuestion;
                if (i != arraySize)
                {
                    baseIndex = baseIndex + 4;
                }
            }
            return tempQuestionArray;
        }

        private Answer[] initAnswers()
        {
            int arraySize = 200;
            int assignmentCounter = 0;
            int linkedQuestion = 0;
            string answerText;
            bool correctAnswer = false;
            Answer[] tempAnswerArray = new Answer[arraySize];

            //this loop will automate the process of adding meaningful test values to the answer array. The data for each answer would need to be manually added for the actual answers or a JSON file would need to be used
            for (int i = 0; i < arraySize; i++)
            {
                if (assignmentCounter == 4)
                {
                    assignmentCounter = 0;
                    linkedQuestion++;
                }
                answerText = "Answer " + i;
                if (assignmentCounter == 3)
                {
                    // set every third answer to be true. This is only for testing.
                    correctAnswer = true;
                }

                Answer tempAnswer = new Answer(linkedQuestion, answerText, correctAnswer);
                correctAnswer = false;
                assignmentCounter++;
            }

            return tempAnswerArray;
        }

        public Question[] PickQuestions(Question[] bankOfQuestions, int amountToPick)
        {
            int arraySize = amountToPick;
            int randomNumber;
            Random random = new Random();
            Question[] tempQuestionArray = new Question[arraySize];
            bool[] pickedQuestions = new bool[bankOfQuestions.Length];
            bool keepPickingRandom = false;

            for (int i = 0; i < arraySize; i++)
            {
                if (i == 0)
                {
                    randomNumber = random.Next(bankOfQuestions.Length);
                    tempQuestionArray[i] = bankOfQuestions[randomNumber];
                    pickedQuestions[randomNumber] = true;
                }
                else
                {
                    randomNumber = random.Next(bankOfQuestions.Length);
                    if (pickedQuestions[randomNumber] == true)
                    {
                        keepPickingRandom = true;

                        while (keepPickingRandom == true)
                        {
                            randomNumber = random.Next(bankOfQuestions.Length);
                            if (pickedQuestions[randomNumber] == false)
                            {
                                tempQuestionArray[i] = bankOfQuestions[randomNumber];
                                pickedQuestions[randomNumber] = true;
                                keepPickingRandom = false;
                            }
                        }
                    }
                    else
                    {
                        tempQuestionArray[i] = bankOfQuestions[randomNumber];
                        pickedQuestions[randomNumber] = true;
                    }
                }
            }
            return tempQuestionArray;
        }
    }

    public class Question
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
    public class Answer
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
