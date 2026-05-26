namespace GuessNum
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
            btnShowAnswer = new Button();
            btnCheck = new Button();
            btnReset = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(94, 65);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(123, 51);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.Location = new Point(94, 150);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Size = new Size(123, 51);
            btnShowAnswer.TabIndex = 1;
            btnShowAnswer.Text = "看答案";
            btnShowAnswer.UseVisualStyleBackColor = true;
            btnShowAnswer.Click += btnShowAnswer_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(94, 338);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(123, 51);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Enabled = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(244, 338);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 51);
            btnReset.TabIndex = 3;
            btnReset.Text = "放棄重來";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 257);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 4;
            label1.Text = "輸入";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 31);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 6;
            label2.Text = "遊戲歷程";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(393, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(298, 327);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnCheck);
            Controls.Add(btnShowAnswer);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnShowAnswer;
        private Button btnCheck;
        private Button btnReset;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListBox listBox1;
    }
}
