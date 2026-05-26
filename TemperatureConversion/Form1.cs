namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                label1.Text = "結果：請輸入正確數字";
                return;
            }

            if (rdoCtoF.Checked)
            {
                double f = value * 9 / 5 + 32;
                label1.Text = $"結果：{value}℃ = {f}℉";
            }
            else if (rdoFtoC.Checked)
            {
                double c = (value - 32) * 5 / 9;
                label1.Text = $"結果：{value}℉ = {c:F1}℃";
            }
            else
            {
                label1.Text = "結果：請選擇轉換方式";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            textBox1.Text += btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }
    }
}
