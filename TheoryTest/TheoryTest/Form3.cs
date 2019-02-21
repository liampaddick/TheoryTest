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
    public partial class Form3 : Form
    {
        public Form3(Question passedQuestion, Result passedResult)
        {
            InitializeComponent();
        }

        private void SetText(Question passedQuestion)
        {
            QuestionNoTextLabel.Text = (passedQuestion.GetQuestionID() + 1).ToString();
            QuestionTextLabel.Text = passedQuestion.GetQuestionText();

            Answer[] tempAnswerArray = passedQuestion.GetPossibleAnswerArray();

            AnswerButton1.Text = tempAnswerArray[0].GetAnswerText();
            AnswerButton2.Text = tempAnswerArray[1].GetAnswerText();
            AnswerButton3.Text = tempAnswerArray[2].GetAnswerText();
            AnswerButton4.Text = tempAnswerArray[3].GetAnswerText();
        }
        private void SetButtonColour(Question passedQuestion, Result passedResult)
        {
            Answer[] tempAnswerArray = passedQuestion.GetPossibleAnswerArray();


        }
    }
}
