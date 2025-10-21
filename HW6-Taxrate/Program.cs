
namespace HW6_Taxrate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入年收入金額: ");
            var input = Console.ReadLine();
            if (!decimal.TryParse(input, out decimal income) || income < 0)
            {
                Console.WriteLine("輸入格式錯誤, 請重新輸入");
                return;
            }
            decimal tax = CalculateTax(income);

            Console.WriteLine($"年收入 {income.ToString("#,0.##")} 元, 所得稅額 {tax:#,0.##}");
            //ToString("#,0.##"): 將數字格式化為千分位表示法, 並保留最多兩位小數
        }

        private static decimal CalculateTax(decimal income)
        {
            var level = new (decimal Upper, decimal Rate)[]
            {
                (540_000m, 0.05m),
                (1_210_000m, 0.12m),
                (2_420_000m, 0.20m),
                (4_530_000m, 0.30m),
                (10_310_000m, 0.40m),
                (decimal.MaxValue, 0.50m),
            };
            decimal tax = 0; //宣告累加稅額的變數,初始值為0
            decimal lower = 0; //宣告每個級距的下限,初始值為0

            foreach (var (upper, rate) in level)
            {
                if (income <= lower)
                {
                    break;
                }
                var taxable = Math.Min(income, upper) - lower; //計算該級距的要被課稅的金額
                //Math.Min(a, b): 傳回兩個值中較小的值
                if (taxable > 0)
                {
                    tax += taxable * rate; //計算該級距的稅額並累加到總稅額
                }
                if (income <= upper)
                {
                    break; //如果收入在此級距內,則結束迴圈
                }
                lower = upper; //更新下限為目前級距的上限
            }
            return tax;
        }
    }
}
