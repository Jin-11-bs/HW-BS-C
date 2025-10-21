namespace _4A0Brule
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
            btnStart = new Button();
            btnAnswer = new Button();
            label1 = new Label();
            textBox = new TextBox();
            btnCheck = new Button();
            btnReset = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(39, 43);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(122, 50);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(39, 131);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(122, 50);
            btnAnswer.TabIndex = 1;
            btnAnswer.Text = "看答案";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 295);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 2;
            label1.Text = "輸入";
            // 
            // textBox
            // 
            textBox.Location = new Point(39, 321);
            textBox.Name = "textBox";
            textBox.Size = new Size(257, 30);
            textBox.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(39, 385);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 42);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(184, 385);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 42);
            btnReset.TabIndex = 5;
            btnReset.Text = "放棄重來";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(380, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(329, 349);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 473);
            Controls.Add(listBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCheck);
            Controls.Add(textBox);
            Controls.Add(label1);
            Controls.Add(btnAnswer);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnAnswer;
        private Label label1;
        private TextBox textBox;
        private Button btnCheck;
        private Button btnReset;
        private ListBox listBox1;
    }
}
