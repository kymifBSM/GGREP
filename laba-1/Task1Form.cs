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
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
        }

        private void task1RunButton1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1ForTask1.Text);
            int num2 = int.Parse(num2ForTask2.Text);
            int num3 = int.Parse(num3ForTask3.Text);
            int res1 = num1 >= 0 ? (num1 * num1) : (num1);
            int res2 = num2 >= 0 ? (num2 * num2) : (num2);
            int res3 = num3 >= 0 ? (num3 * num3) : (num3);
            res1ForTask1.Text = res1.ToString();
            res2ForTask2.Text = res2.ToString();
            res3ForTask3.Text = res3.ToString();
        }

        private void backTask1Button_Click(object sender, EventArgs e)
        {
            MainForm bfrm1 = new MainForm();
            bfrm1.Show();
            this.Hide();
        }
    }
}
