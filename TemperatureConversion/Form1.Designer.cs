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
            rdoCtoF = new RadioButton();
            rdoFtoC = new RadioButton();
            groupBox1 = new GroupBox();
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
            label1 = new Label();
            btnConvert = new Button();
            btnClear = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rdoCtoF
            // 
            rdoCtoF.AutoSize = true;
            rdoCtoF.Location = new Point(53, 26);
            rdoCtoF.Name = "rdoCtoF";
            rdoCtoF.Size = new Size(120, 23);
            rdoCtoF.TabIndex = 0;
            rdoCtoF.TabStop = true;
            rdoCtoF.Text = "攝氏轉為華氏";
            rdoCtoF.UseVisualStyleBackColor = true;
            // 
            // rdoFtoC
            // 
            rdoFtoC.AutoSize = true;
            rdoFtoC.Location = new Point(53, 73);
            rdoFtoC.Name = "rdoFtoC";
            rdoFtoC.Size = new Size(120, 23);
            rdoFtoC.TabIndex = 1;
            rdoFtoC.TabStop = true;
            rdoFtoC.Text = "華氏轉為攝氏";
            rdoFtoC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoCtoF);
            groupBox1.Controls.Add(rdoFtoC);
            groupBox1.Location = new Point(39, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btn1
            // 
            btn1.Location = new Point(335, 129);
            btn1.Name = "btn1";
            btn1.Size = new Size(38, 40);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(399, 129);
            btn2.Name = "btn2";
            btn2.Size = new Size(38, 40);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(467, 129);
            btn3.Name = "btn3";
            btn3.Size = new Size(38, 40);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(335, 196);
            btn4.Name = "btn4";
            btn4.Size = new Size(38, 40);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(399, 196);
            btn5.Name = "btn5";
            btn5.Size = new Size(38, 40);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(467, 196);
            btn6.Name = "btn6";
            btn6.Size = new Size(38, 40);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(335, 257);
            btn7.Name = "btn7";
            btn7.Size = new Size(38, 40);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(399, 257);
            btn8.Name = "btn8";
            btn8.Size = new Size(38, 40);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(467, 257);
            btn9.Name = "btn9";
            btn9.Size = new Size(38, 40);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(335, 319);
            btn0.Name = "btn0";
            btn0.Size = new Size(38, 40);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(399, 319);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(38, 40);
            btnDot.TabIndex = 13;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(612, 319);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 14;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(612, 230);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(113, 52);
            btnConvert.TabIndex = 15;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(786, 230);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 52);
            btnClear.TabIndex = 16;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(612, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 27);
            textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 535);
            Controls.Add(textBox1);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(label1);
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

        private RadioButton rdoCtoF;
        private RadioButton rdoFtoC;
        private GroupBox groupBox1;
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
        private Label label1;
        private Button btnConvert;
        private Button btnClear;
        private TextBox textBox1;
    }
}
