namespace _4A0Brule
{
    public partial class Form1 : Form
    {
        private string answer = ""; //�s��q���諸�H������
        private bool gameStarted = false; //�l�ܹC���O�_�}�l
        //�C���}�l�e�����\�����D�M�ˬd���s,�}�l�C�����s�Q���U��~������ true
        private readonly Random rng = new Random(); //�ΨӲ��Ͷü�
        // �����H���Ʋ��;��A�T�O�h���ͦ�������
        public Form1()
        {
            InitializeComponent();
            UpdateBounds();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartNewGame();
            MessageBox.Show("�C���}�l!�п�J�|�줣���ƪ��Ʀr�C");
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("�Х����}�l�C��!");
                return;
            }

            MessageBox.Show($"���׬O: {answer}");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("�Х����}�l�C��!");
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
                MessageBox.Show("���ߧA����F!");
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
                MessageBox.Show("�Х����}�l�C��!");
                return;
            }
            StartNewGame();
            MessageBox.Show("�w���s�}�l�C��!�п�J�|�줣���ƪ��Ʀr�C");
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
                if (!digits.Contains(num)) //�ˬd�o�ӼƦr�O�_�w�s�b
                {
                    digits.Add(num); //�p�G���s�b�N�[�J�M��
                }
            }
            return string.Concat(digits); //�⵲�G��_�Ӧ���r
        }

        //��W Tuple �^�ǫ��O (Named Tuple Return Type), �@���^�Ǩ�ӭ�
        private (bool isValid, string message) ValidateGuess(string guess)
        {
            // bool isValid �� �N�����ҬO�_�q�L�]true / false�^
            // string message �� ���ҥ��Ѯɪ����~�T��
            if (guess.Length != 4)
            {
                return (false, "�п�J�|��Ʀr�C");
            }
            if (!guess.All(char.IsDigit))
            {
                return (false, "�ȯ��J�Ʀr�C");
            }
            if (guess.Distinct().Count() != 4)
            {
                return (false, "�Ʀr���i���ơC");
            }
            return (true, string.Empty);
        }
    }

}
