using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_1
{
    public partial class Task6Form : Form
    {
        public Task6Form()
        {
            InitializeComponent();
        }

        private void task6RunButton1_Click(object sender, EventArgs e)
        {
            res1ForTask6.Text = "";
            int a;
            int b;
            for (a = 10; a <= 99; a++)
            {
                b = (a / 10 + a % 10);
                if (b + (b * b) == a)
                    res1ForTask6.Text += a.ToString() + " ";
            }
        }

        private void backTask6Button_Click(object sender, EventArgs e)
        {
            MainForm bfrm1 = new MainForm();
            bfrm1.Show();
            this.Hide();
        }
    }
}
