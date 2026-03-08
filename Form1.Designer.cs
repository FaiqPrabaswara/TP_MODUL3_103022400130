namespace TP_MODUL3_103022400130
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
            lblOutput = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            button10 = new Button();
            button11 = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Font = new Font("Source Han Sans CN Bold", 30F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblOutput.Location = new Point(365, 43);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(90, 74);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "00";
            lblOutput.TextAlign = ContentAlignment.MiddleRight;
            lblOutput.Click += label1_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(265, 120);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 29);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(365, 120);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 29);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(265, 190);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(365, 190);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(465, 190);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(265, 155);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(365, 155);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 29);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(465, 155);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 29);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(465, 120);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 29);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(365, 225);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 10;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(465, 225);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 11;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(265, 225);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 29);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn0);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btn7;
        private Button btn8;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn9;
        private Button button10;
        private Button button11;
        private Button btn0;
    }
}
