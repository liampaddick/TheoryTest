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
        List<bool> localResults = new List<bool> { };
        public Form2(List<bool> passedResults)
        {
            InitializeComponent();
            localResults = passedResults;
        }
    }
}
