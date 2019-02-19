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
        List<bool> localResultsList = new List<bool> { };
        List<Button> createdButtonsList = new List<Button> { };
        public Form2(List<bool> passedResults)
        {
            InitializeComponent();
            localResultsList = passedResults;

            for (int i = 0; i < localResultsList.Count(); i++)
            {
                Button tempButton = new Button();
                tempButton.Name = "Button" + i.ToString();
                tempButton.Text = tempButton.Name;
                tempButton.Size = new Size(20, 20);
                tempButton.Location = new Point(50 + (50 * i), 50);
                createdButtonsList.Add(tempButton);
                Controls.Add(tempButton);
            }
        }
    }
}
