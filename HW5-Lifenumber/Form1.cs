using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HW5_Lifenumber
{
    public partial class Form1 : Form
    {
        private List<string> lines;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lines = await LoadLifeNumberText();
        }

        private string GetStarlines()
        {
            int star = Star();
            var lifeNumber = CalculateLifeNumber();
            string result = lines[star * 10 + lifeNumber];
            return result;
        }

        private string GetStarsigns()
        {
            int star = Star();
            string starsign = lines[star*10];
            return starsign;
        }
        private async Task<List<string>> LoadLifeNumberText()
        {
            string lifeNumber = "lifenumber.txt";
            if (File.Exists(lifeNumber))
            {
                var lines = await File.ReadAllLinesAsync(lifeNumber);
                var result = lines.Select(x => x.Trim())
                     .Where(x => !string.IsNullOrWhiteSpace(x))
                     .ToList();
                return result;
            }
            else
            {
                MessageBox.Show("找不到此檔案");
                return new List<string>();
            }
        }
        private int CalculateLifeNumber()
        {
            DateTime date = dateTimePicker1.Value;
            string s = date.ToString("yyyyMMdd");
            int totalnum = 0;
            foreach (char c in s)
            {
                totalnum += int.Parse(c.ToString());
            }

            while (totalnum > 9)
            {
                int sum = 0;
                while (totalnum > 0)
                {
                    sum += totalnum % 10;
                    totalnum = totalnum / 10;
                }
                totalnum = sum;
            }
            return totalnum;

        }

        private int Star()
        {
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return 10; //水瓶座
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                return 11; //雙魚座
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return 0; //牡羊座
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return 1; //金牛座
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return 2; //雙子座
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return 3; //巨蟹座
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return 4; //獅子座
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return 5; //處女座
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return 6; //天秤座
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return 7; //天蠍座
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return 8; //射手座
            else
                return 9; //魔羯座
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = GetStarsigns();
            string y = GetStarlines();
            label2.Text = $"你的星座是 {x}" + Environment.NewLine + $"{y}";
        }


    }
}
