namespace _4A0Brule
{
    public partial class Form1 : Form
    {
        private string answer = ""; //存放電腦選的隨機答案
        private bool gameStarted = false; //追蹤遊戲是否開始
        //遊戲開始前不允許按答題和檢查按鈕,開始遊戲按鈕被按下後才切換為 true
        private readonly Random rng = new Random(); //用來產生亂數
        // 全域隨機數產生器，確保多次生成不重複
        public Form1()
        {
            InitializeComponent();
            UpdateBounds();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartNewGame();
            MessageBox.Show("遊戲開始!請輸入四位不重複的數字。");
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("請先按開始遊戲!");
                return;
            }

            MessageBox.Show($"答案是: {answer}");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("請先按開始遊戲!");
                return;
            }

            string guess = textBox.Text.Trim();
            var validation = ValidateGuess(guess);
            if (!validation.isValid)
            {
                MessageBox.Show(validation.message);
                return;
            }
            string result = CheckGuess(answer, guess);
            listBox1.Items.Add($"{guess} : {result}");

            if (result == "4A0B")
            {
                MessageBox.Show("恭喜你答對了!");
                gameStarted = false;
                UpdateButtons();
            }
            textBox.Clear();
            textBox.Focus();

        }
        private string CheckGuess(string answer, string guess)
        {
            int A = 0, B = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                {
                    A++;
                }
                else if (answer.Contains(guess[i]))
                {
                    B++;
                }
            }
            return $"{A}A{B}B";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("請先按開始遊戲!");
                return;
            }
            StartNewGame();
            MessageBox.Show("已重新開始遊戲!請輸入四位不重複的數字。");
        }
        private void StartNewGame()
        {
            answer = GenerateAnswer();
            listBox1.Items.Clear();
            textBox.Clear();
            gameStarted = true;
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            btnCheck.Enabled = gameStarted;
            btnAnswer.Enabled = gameStarted;
            btnReset.Enabled = gameStarted;
        }

        private string GenerateAnswer()
        {
            Random rng = new Random();
            List<int> digits = new List<int>();

            while (digits.Count < 4)
            {
                int num = rng.Next(0, 10);
                if (!digits.Contains(num)) //檢查這個數字是否已存在
                {
                    digits.Add(num); //如果不存在就加入清單
                }
            }
            return string.Concat(digits); //把結果串起來成文字
        }

        //具名 Tuple 回傳型別 (Named Tuple Return Type), 一次回傳兩個值
        private (bool isValid, string message) ValidateGuess(string guess)
        {
            // bool isValid → 代表驗證是否通過（true / false）
            // string message → 驗證失敗時的錯誤訊息
            if (guess.Length != 4)
            {
                return (false, "請輸入四位數字。");
            }
            if (!guess.All(char.IsDigit))
            {
                return (false, "僅能輸入數字。");
            }
            if (guess.Distinct().Count() != 4)
            {
                return (false, "數字不可重複。");
            }
            return (true, string.Empty);
        }
    }

}
