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
    public partial class Form2 : Form
    {
        public Form2(List<bool> passedResults)
        {
            InitializeComponent();
            List<Button> createdButtonsList = new List<Button> { };
            buttonCreation(passedResults);
        }
        private List<Button> buttonCreation (List<bool> resultsList)
        {
            int startingXCo = 50;
            int xCo = 50;
            int yCo = 50;
            int multiplier = 0;
            List<Button> tempButtonList = new List<Button> { };

            for (int i = 0; i < resultsList.Count(); i++)
            {
                Button tempButton = new Button();
                tempButton.Name = "Button" + i.ToString();
                tempButton.Text = tempButton.Name;
                tempButton.Size = new Size(20, 20);
                if (resultsList[i] == true)
                {
                    tempButton.BackColor = Color.Green;
                }
                else if (resultsList[i] == false)
                {
                    tempButton.BackColor = Color.Red;
                }

                if (i % 5 == 0)
                {
                    yCo = yCo + 50;
                    xCo = startingXCo;
                    multiplier = 0;
                }

                tempButton.Location = new Point(xCo + (xCo * multiplier), yCo);
                tempButton.Click += new EventHandler(ButtonClick);
                multiplier++;
                tempButtonList.Add(tempButton);
                Controls.Add(tempButton);
            }
            return tempButtonList;
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show(clickedButton.Name + " Clicked");
        }
    }
}
