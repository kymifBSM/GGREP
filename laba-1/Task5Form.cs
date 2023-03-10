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
    public partial class Task5Form : Form
    {
        public Task5Form()
        {
            InitializeComponent();
        }

        private void task5RunButton1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1ForTask5.Text);
            int num2 = int.Parse(num2ForTask5.Text);
            int sum = 0;
            if (num1>0 && num2>0 && num1 < num2)
            {
                for (int a = num1; a <= num2; a++)
                {
                    if (a % 3 == 0 && (a % 10 == 2 || a%10==4 || a%8==8)) {
                        sum += a;
                            };
                }
            }
            res1ForTask5.Text = sum.ToString();
        }

        private void backTask5Button_Click(object sender, EventArgs e)
        {
            MainForm bfrm1 = new MainForm();
            bfrm1.Show();
            this.Hide();
        }
    }
}
