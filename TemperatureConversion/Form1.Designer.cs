namespace TemperatureConversion
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
            groupBox1 = new GroupBox();
            rbF2C = new RadioButton();
            rbC2F = new RadioButton();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            txtInput = new TextBox();
            btnConvert = new Button();
            btnClear = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbF2C);
            groupBox1.Controls.Add(rbC2F);
            groupBox1.Location = new Point(29, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbF2C
            // 
            rbF2C.AutoSize = true;
            rbF2C.Location = new Point(24, 96);
            rbF2C.Name = "rbF2C";
            rbF2C.Size = new Size(161, 27);
            rbF2C.TabIndex = 1;
            rbF2C.TabStop = true;
            rbF2C.Text = "華氏轉換為攝氏";
            rbF2C.UseVisualStyleBackColor = true;
            // 
            // rbC2F
            // 
            rbC2F.AutoSize = true;
            rbC2F.Location = new Point(24, 45);
            rbC2F.Name = "rbC2F";
            rbC2F.Size = new Size(161, 27);
            rbC2F.TabIndex = 0;
            rbC2F.TabStop = true;
            rbC2F.Text = "攝氏轉換為華氏";
            rbC2F.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(358, 66);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 45);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(413, 67);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 45);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(468, 67);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 45);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(358, 117);
            btn4.Name = "btn4";
            btn4.Size = new Size(49, 45);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(413, 118);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 45);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(468, 118);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 45);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(358, 168);
            btn7.Name = "btn7";
            btn7.Size = new Size(49, 45);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(413, 169);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 45);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(468, 169);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 45);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(358, 219);
            btn0.Name = "btn0";
            btn0.Size = new Size(49, 45);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(413, 220);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(49, 45);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += BtnDot_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(582, 109);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(271, 30);
            txtInput.TabIndex = 12;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(582, 163);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(112, 34);
            btnConvert.TabIndex = 13;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += BtnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(700, 163);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 220);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(txtInput);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbF2C;
        private RadioButton rbC2F;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnDot;
        private TextBox txtInput;
        private Button btnConvert;
        private Button btnClear;
        private Label label1;
    }
}
