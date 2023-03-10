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
    public partial class Task4Form : Form
    {
        public Task4Form()
        {
            InitializeComponent();
        }

        private void task4RunButton1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(num1ForTask4.Text);
            int c = 1;
            for (int b = 2; b <= num; ++b)
                c *= b;
            res1ForTask4.Text = c.ToString();
        }

        private void backTask4Button_Click(object sender, EventArgs e)
        {
            MainForm bfrm1 = new MainForm();
            bfrm1.Show();
            this.Hide();
        }
    }
}
