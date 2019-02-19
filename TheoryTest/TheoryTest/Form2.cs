﻿using System;
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
            List<bool> localResultsList = new List<bool> { };
            List<Button> createdButtonsList = new List<Button> { };
            localResultsList = passedResults;
            int startingXCo = 50;
            int startingYCo = 50;
            int xCo = 50;
            int yCo = 50;
            int multiplier = 0;

            for (int i = 0; i < localResultsList.Count() + 5; i++)
            {
                Button tempButton = new Button();
                tempButton.Name = "Button" + i.ToString();
                tempButton.Text = tempButton.Name;
                tempButton.Size = new Size(20, 20);

                if (i % 5 == 0)
                {
                    yCo = yCo + 50;
                    xCo = startingXCo;
                    multiplier = 0;
                }

                tempButton.Location = new Point(xCo + (xCo * multiplier), yCo);
                multiplier++;
                createdButtonsList.Add(tempButton);
                Controls.Add(tempButton);
            }
        }
    }
}
