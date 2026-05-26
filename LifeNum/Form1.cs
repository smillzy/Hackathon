namespace LifeNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Today;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            DateTime birthday = dtpBirthday.Value;

            string zodiac = GetZodiacFromBirthday(birthday);
            int lifeNumber = GetLifeNumber(birthday);

            string comment = GetCommentFromFile(zodiac, lifeNumber);

            lblResult.Text =
                $"你的星座是 {zodiac}\n" +
                $"你的{comment}";
        }

        public string GetZodiacFromBirthday(DateTime dtBirthDay)
        {
            int birthDate = dtBirthDay.Month * 100 + dtBirthDay.Day;

            int[] zodiacBound =
            {
            120, 220, 321, 421, 521, 622,
            723, 823, 923, 1023, 1121, 1222, 1320
            };

            string[] zodiacs =
            {
            "水瓶座", "雙魚座", "牡羊座", "金牛座", "雙子座", "巨蟹座",
            "獅子座", "處女座", "天秤座", "天蠍座", "射手座", "摩羯座"
            };

            // 1/1 ~ 1/19 是摩羯座
            if (birthDate < 120)
            {
                birthDate += 1200;
            }

            for (int i = 0; i < zodiacBound.Length - 1; i++)
            {
                if (zodiacBound[i] <= birthDate && birthDate < zodiacBound[i + 1])
                {
                    return zodiacs[i];
                }
            }

            return "找不到星座";
        }

        private int GetLifeNumber(DateTime birthday)
        {
            string dateText = birthday.ToString("yyyyMMdd");

            int total = 0;

            foreach (char c in dateText)
            {
                total += int.Parse(c.ToString());
            }

            while (total >= 10)
            {
                int temp = 0;

                foreach (char c in total.ToString())
                {
                    temp += int.Parse(c.ToString());
                }

                total = temp;
            }

            return total;
        }

        private string GetCommentFromFile(string zodiac, int lifeNumber)
        {
            string filePath = "生命靈數.txt";

            if (!File.Exists(filePath))
            {
                return "找不到生命靈數.txt";
            }

            string[] lines = File.ReadAllLines(filePath); // 文字檔每一行讀進陣列

            bool isTargetZodiac = false; // 是不是已經進入我要找的星座區塊？

            foreach (string line in lines)
            {
                string cleanLine = line.Trim(); // 去掉每行前後空白

                if (cleanLine.Contains("【")) // 判斷這一行是不是星座標題
                {
                    isTargetZodiac = cleanLine.Contains(zodiac);
                }

                if (isTargetZodiac && cleanLine.StartsWith($"生命靈數{lifeNumber}："))
                {
                    return cleanLine;
                }
            }

            return "找不到對應的評論";
        }
    }
}
