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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            MainMenuText.Text = "start button pressed";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MainMenuText.Text = "exit button pressed";
        }
    }
}
