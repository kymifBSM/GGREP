using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace laba_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonToTask1Branch_Click(object sender, EventArgs e)
        {
            Task1Form tfrm1 = new Task1Form();
            tfrm1.Show();
            this.Hide();
        }

        private void buttonToTask2Branch_Click(object sender, EventArgs e)
        {
            Task2Form tfrm2 = new Task2Form();
            tfrm2.Show();
            this.Hide();
        }

        private void buttonToTask3Branch_Click(object sender, EventArgs e)
        {
            Task3Form tfrm3 = new Task3Form();
            tfrm3.Show();
            this.Hide();
        }

        private void buttonToTask1Cycle_Click(object sender, EventArgs e)
        {
            Task4Form tfrm4 = new Task4Form();
            tfrm4.Show();
            this.Hide();
        }

        private void buttonToTask2Cycle_Click(object sender, EventArgs e)
        {
            Task5Form tfrm5 = new Task5Form();
            tfrm5.Show();
            this.Hide();
        }

        private void buttonToTask3Cycle_Click(object sender, EventArgs e)
        {
            Task6Form tfrm6 = new Task6Form();
            tfrm6.Show();
            this.Hide();
        }
    }
}