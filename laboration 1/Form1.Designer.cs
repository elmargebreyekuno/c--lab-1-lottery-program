﻿namespace laboration_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label4 = new Label();
            textBox11 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Din lotto rad";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(271, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(356, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(79, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(441, 19);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(79, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(526, 19);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(79, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(611, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(79, 23);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(261, 74);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(89, 23);
            textBox8.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 78);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 10;
            label2.Text = "Antal draggningar: ";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(356, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "lotta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 127);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 12;
            label3.Text = "5 rätt";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(166, 124);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(89, 23);
            textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(311, 124);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(89, 23);
            textBox10.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 127);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 14;
            label4.Text = "6 rätt";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(457, 124);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(89, 23);
            textBox11.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 127);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 16;
            label5.Text = "7 rätt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 180);
            Controls.Add(textBox11);
            Controls.Add(label5);
            Controls.Add(textBox10);
            Controls.Add(label4);
            Controls.Add(textBox9);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label4;
        private TextBox textBox11;
        private Label label5;
    }
}