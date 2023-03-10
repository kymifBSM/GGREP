namespace laba_1
{
    partial class Task2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backTask2Button = new System.Windows.Forms.Button();
            this.task2RunButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.res1ForTask2 = new System.Windows.Forms.Label();
            this.num1ForTask2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backTask2Button
            // 
            this.backTask2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.backTask2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backTask2Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(12)))), ((int)(((byte)(92)))));
            this.backTask2Button.FlatAppearance.BorderSize = 2;
            this.backTask2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(93)))), ((int)(((byte)(35)))));
            this.backTask2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.backTask2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backTask2Button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backTask2Button.Location = new System.Drawing.Point(12, 9);
            this.backTask2Button.Name = "backTask2Button";
            this.backTask2Button.Size = new System.Drawing.Size(89, 40);
            this.backTask2Button.TabIndex = 17;
            this.backTask2Button.Text = "НАЗАД";
            this.backTask2Button.UseVisualStyleBackColor = false;
            this.backTask2Button.Click += new System.EventHandler(this.backTask2Button_Click);
            // 
            // task2RunButton1
            // 
            this.task2RunButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.task2RunButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.task2RunButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(12)))), ((int)(((byte)(92)))));
            this.task2RunButton1.FlatAppearance.BorderSize = 2;
            this.task2RunButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(93)))), ((int)(((byte)(35)))));
            this.task2RunButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.task2RunButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task2RunButton1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.task2RunButton1.Location = new System.Drawing.Point(327, 348);
            this.task2RunButton1.Name = "task2RunButton1";
            this.task2RunButton1.Size = new System.Drawing.Size(162, 76);
            this.task2RunButton1.TabIndex = 16;
            this.task2RunButton1.Text = "Начать безумие";
            this.task2RunButton1.UseVisualStyleBackColor = false;
            this.task2RunButton1.Click += new System.EventHandler(this.task2RunButton1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(70, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 58);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите число для проверки на чётность: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Определить, является ли данное целое число четным";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ветвление. Задание №2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.res1ForTask2);
            this.panel1.Controls.Add(this.num1ForTask2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.backTask2Button);
            this.panel1.Controls.Add(this.task2RunButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // res1ForTask2
            // 
            this.res1ForTask2.BackColor = System.Drawing.Color.White;
            this.res1ForTask2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res1ForTask2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.res1ForTask2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.res1ForTask2.Location = new System.Drawing.Point(325, 240);
            this.res1ForTask2.Name = "res1ForTask2";
            this.res1ForTask2.Size = new System.Drawing.Size(155, 24);
            this.res1ForTask2.TabIndex = 20;
            // 
            // num1ForTask2
            // 
            this.num1ForTask2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num1ForTask2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num1ForTask2.Location = new System.Drawing.Point(423, 181);
            this.num1ForTask2.Name = "num1ForTask2";
            this.num1ForTask2.Size = new System.Drawing.Size(155, 26);
            this.num1ForTask2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(70, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 45);
            this.label3.TabIndex = 18;
            this.label3.Text = "Результат проверки числа: ";
            // 
            // Task2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Task2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task2Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button backTask2Button;
        private Button task2RunButton1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox num1ForTask2;
        private Label res1ForTask2;
    }
}