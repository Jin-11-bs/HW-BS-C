using System.Drawing.Drawing2D;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // �إ߼Ʀr��L�@�Ψƥ�
            // ������ݭn�@�Ψƥ�?
            // �]�Ʀr���s���\�������A���O�N���U���Ʀr��ܦb��J�ؤ�
            // �p�G�C�ӫ��s���g�@�ӿW�ߪ��ƥ�B�z��k�A�|�y���{���X���ƥB���H���@
            // �ϥΦ@�Ψƥ�i�H���{���X��²��B����޲z
            // �@�Ψƥ󪺹�{�覡�O�N�Ҧ��Ʀr���s�� Click �ƥ󳣫��V�P�@�Өƥ�B�z��k
            // �b�ƥ�B�z��k���A�i�H�ϥ� sender �Ѽƨӿ��ѬO���ӫ��s�Q���U�A�M����o�ӫ��s����r���e

            // �N�Ҧ��Ʀr���s��J�@�Ӱ}�C���A�M��ϥΰj�鬰�C�ӫ��s�q�\�ۦP�� Click �ƥ�B�z��k digiBtns_Click
            var digiBtns = new[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var b in digiBtns) b.Click += DigiBtns_Click;
            // b.Click �O�u�ƥ�v, ���s�Q�I�����q��
            // += �O�u�q�\�ƥ�v���g�k //-= �O�u�����q�\�v���g�k
            // digiBtns_Click �O�u��k�v, ��ƥ�QĲ�o�ɷ|���檺��k

            btnDot.Click += BtnDot_Click;
            // btnDot ���W�߳W�h�]���୫�ơ^,�ҥH�t�~�g�@�Өƥ�B�z��k

            btnConvert.Click += BtnConvert_Click;
            btnClear.Click += BtnClear_Click;


            rbC2F.Checked = true; // �w�]��������ؤ�
            // RadioButton �� Checked �ݩʪ�ܸӫ��s�O�_�Q���
            // ���O�O bool (true:�o�ӿﶵ�Q�Ŀ�/false:�S�Q��)
            // �]�� RadioButton ����������A�ҥH�u�ݭn�]�w�䤤�@�� Checked �ݩʬ� true 
            label1.Text = "���G";
        }

        // ��Ʀr�K���J�س̫᭱
        private void DigiBtns_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender; // �N sender �૬�� Button ����
            AppendToInput(btn.Text); // �N���s����r���e�ǵ� AppendToInput ��k
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                AppendToInput("0.");
            } 
            else if (!txtInput.Text.Contains("."))
            {
                // �p�G�ثe�٨S���p���I�A�~�i�H�[�@�ӡu.�v
                AppendToInput(".");
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //�u�p�G�S�����\�ন�Ʀr�v���ܡ]�N���J���~�^�A���N���� { ... }�̪����e
            // ���O�Ʀr���� = TryGetInput �^�� false, !TryGetInput => !false = true
            if (!TryGetInput(out double value))
            {
                MessageBox.Show("�п�J���T���Ʀr�]�i�t�p�Ʃέt���^�C", "�榡���~");
                txtInput.Focus();
                txtInput.SelectAll();
                return;
            }

            if (rbC2F.Checked)
            {
                double f = C2F(value);
                label1.Text = $"���G�G{value}�XC = {f:F1}�XF";
                // F1 �N��O�d 1 ��p��
            }
            else // rbF2C
            {
                double c = F2C(value);
                label1.Text = $"���G�G{value}�XF = {c:F1}�XC";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            label1.Text = "���G�G";
            txtInput.Focus();
        }

        //�C�ӫ��s�����@���ݩ� .Text�A�N�O��ܦb���s�W���r
        // btn1.Text = "1"
        private void AppendToInput(string text)
        {
            // �קK�e�� 0 ���D�G�Y�ثe�O "0" �B���O��J�p���I�A�令�s�r��
            if (txtInput.Text == "0" && text != ".")
            {
                txtInput.Text = text;
            }
            else
            {
                txtInput.AppendText(text);
            }
            txtInput.Focus(); // �N�J�I�^���J�ءA��K�~���J
            txtInput.SelectionStart = txtInput.Text.Length; // �N��в����r�̫�
        }

        //�T�{��J����r�ण���ন�Ʀr
        private bool TryGetInput(out double value)
        {
            return double.TryParse(txtInput.Text, out value);
            //out �O C# ���@�ذѼƶǻ��覡, �Q�Τ�k��@�ӭȦ^�Ǩ�~���h
            //value �O�@�ӡu�n����k���A��J���G�v���ܼ�
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
