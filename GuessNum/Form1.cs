using System.Linq;
namespace GuessNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string answer = "";

        private void GenerateAnswer()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            while (numbers.Count < 4)
            {
                int n = random.Next(0, 10);

                if (!numbers.Contains(n))
                {
                    numbers.Add(n);
                }
            }

            answer = string.Join("", numbers);
        }

        private string CheckAB(string guess)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == answer[i])
                {
                    a++;
                }
                else if (answer.Contains(guess[i]))
                {
                    b++;
                }
            }

            return $"{a}A{b}B";
        }

        private bool IsValidGuess(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("請輸入數字");
                textBox1.Clear();
                return false;
            }

            if (input.Length != 4)
            {
                MessageBox.Show("請輸入4位數字");
                textBox1.Clear();
                return false;
            }

            if (!int.TryParse(input, out int number))
            {
                MessageBox.Show("只能輸入數字");
                textBox1.Clear();
                return false;
            }

            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text.Trim();

            if (!IsValidGuess(guess))
            {
                return;
            }

            string result = CheckAB(guess);

            listBox1.Items.Add($"{guess}：{result}");

            if (result == "4A0B")
            {
                MessageBox.Show("過關");
            }

            textBox1.Clear();
            textBox1.Focus(); // 游標停在輸入框內
            answer = "";
            btnCheck.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("遊戲已開始，請先完成或按「放棄重來」。");
                return;
            }

            GenerateAnswer();

            btnCheck.Enabled = true;

            listBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Focus();

            MessageBox.Show("遊戲開始");
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            MessageBox.Show($"答案是：{answer}");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("目前尚未開始遊戲");
                return;
            }

            GenerateAnswer();

            listBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Focus();

            MessageBox.Show("已重新開始");
        }
    }
}
