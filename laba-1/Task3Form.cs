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
    public partial class Task3Form : Form
    {
        public Task3Form()
        {
            InitializeComponent();
        }

        private void task3RunButton1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1ForTask3.Text);
            int max = num1 % 10;
            int n1 = num1 / 10 % 10;
            if (num1 >= 10 && num1 <= 99)
            {
                if (max > n1)
                {
                    res1ForTask3.Text = $@"В числе {num1}, число {max} - наибольшее";
                }
                else
                {
                    res1ForTask3.Text = $@"В числе {num1}, число {n1} - наибольшее";
                };
            }
            else
            {
                res1ForTask3.Text = $@"Число {num1} недвузначно";
            };
        }

        private void backTask3Button_Click(object sender, EventArgs e)
        {
            MainForm bfrm1 = new MainForm();
            bfrm1.Show();
            this.Hide();
        }
    }
}
