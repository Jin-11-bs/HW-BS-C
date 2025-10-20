using System.Drawing.Drawing2D;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 建立數字鍵盤共用事件
            // 為什麼需要共用事件?
            // 因數字按鈕的功能類似，都是將按下的數字顯示在輸入框中
            // 如果每個按鈕都寫一個獨立的事件處理方法，會造成程式碼重複且難以維護
            // 使用共用事件可以讓程式碼更簡潔且易於管理
            // 共用事件的實現方式是將所有數字按鈕的 Click 事件都指向同一個事件處理方法
            // 在事件處理方法中，可以使用 sender 參數來辨識是哪個按鈕被按下，然後取得該按鈕的文字內容

            // 將所有數字按鈕放入一個陣列中，然後使用迴圈為每個按鈕訂閱相同的 Click 事件處理方法 digiBtns_Click
            var digiBtns = new[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var b in digiBtns) b.Click += DigiBtns_Click;
            // b.Click 是「事件」, 按鈕被點擊的通知
            // += 是「訂閱事件」的寫法 //-= 是「取消訂閱」的寫法
            // digiBtns_Click 是「方法」, 當事件被觸發時會執行的方法

            btnDot.Click += BtnDot_Click;
            // btnDot 有獨立規則（不能重複）,所以另外寫一個事件處理方法

            btnConvert.Click += BtnConvert_Click;
            btnClear.Click += BtnClear_Click;


            rbC2F.Checked = true; // 預設選擇攝氏轉華氏
            // RadioButton 的 Checked 屬性表示該按鈕是否被選取
            // 型別是 bool (true:這個選項被勾選/false:沒被選)
            // 因為 RadioButton 有互斥機制，所以只需要設定其中一個 Checked 屬性為 true 
            label1.Text = "結果";
        }

        // 把數字貼到輸入框最後面
        private void DigiBtns_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender; // 將 sender 轉型為 Button 類型
            AppendToInput(btn.Text); // 將按鈕的文字內容傳給 AppendToInput 方法
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                AppendToInput("0.");
            } 
            else if (!txtInput.Text.Contains("."))
            {
                // 如果目前還沒有小數點，才可以加一個「.」
                AppendToInput(".");
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //「如果沒有成功轉成數字」的話（代表輸入錯誤），那就執行 { ... }裡的內容
            // 不是數字的話 = TryGetInput 回傳 false, !TryGetInput => !false = true
            if (!TryGetInput(out double value))
            {
                MessageBox.Show("請輸入正確的數字（可含小數或負號）。", "格式錯誤");
                txtInput.Focus();
                txtInput.SelectAll();
                return;
            }

            if (rbC2F.Checked)
            {
                double f = C2F(value);
                label1.Text = $"結果：{value}°C = {f:F1}°F";
                // F1 代表保留 1 位小數
            }
            else // rbF2C
            {
                double c = F2C(value);
                label1.Text = $"結果：{value}°F = {c:F1}°C";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            label1.Text = "結果：";
            txtInput.Focus();
        }

        //每個按鈕都有一個屬性 .Text，就是顯示在按鈕上的字
        // btn1.Text = "1"
        private void AppendToInput(string text)
        {
            // 避免前導 0 問題：若目前是 "0" 且不是輸入小數點，改成新字元
            if (txtInput.Text == "0" && text != ".")
            {
                txtInput.Text = text;
            }
            else
            {
                txtInput.AppendText(text);
            }
            txtInput.Focus(); // 將焦點回到輸入框，方便繼續輸入
            txtInput.SelectionStart = txtInput.Text.Length; // 將游標移到文字最後
        }

        //確認輸入的文字能不能轉成數字
        private bool TryGetInput(out double value)
        {
            return double.TryParse(txtInput.Text, out value);
            //out 是 C# 的一種參數傳遞方式, 利用方法把一個值回傳到外面去
            //value 是一個「要讓方法幫你填入結果」的變數
        }
        private static double C2F(double c)
        {
            return c * 9 / 5 + 32;
        }
        private static double F2C(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
