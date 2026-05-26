namespace LifeNum
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
            dtpBirthday = new DateTimePicker();
            btnAnalyze = new Button();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 86);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "請選擇生日";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(72, 136);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(250, 27);
            dtpBirthday.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(102, 209);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(167, 45);
            btnAnalyze.TabIndex = 2;
            btnAnalyze.Text = "分析結果";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 86);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 3;
            label2.Text = "關於你";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(405, 146);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(360, 120);
            lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(btnAnalyze);
            Controls.Add(dtpBirthday);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBirthday;
        private Button btnAnalyze;
        private Label label2;
        private Label lblResult;
    }
}
