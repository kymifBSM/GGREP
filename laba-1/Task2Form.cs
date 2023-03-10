using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void task2RunButton1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1ForTask2.Text);
            if (num1 % 2 == 0)
            {
                res1ForTask2.Text = $@"{num1} - четно";
            }
            else
            {
                res1ForTask2.Text = $@"{num1} - нечетно";
            }
        }

        private void backTask2Button_Click(object sender, EventArgs e)
        {
            MainForm bfrm1 = new MainForm();
            bfrm1.Show();
            this.Hide();
        }
    }
}
