using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                int k = Convert.ToInt32(textBox2.Text);
                
                if (n < 1000 || k < 1000)
                {
                    label4.Text = "Слишком маленькое число!";
                    return;
                }

                int tripleNumbersCount = 0;

                for (int i = n; i <= k; i++) 
                { 
                    string check_number = i.ToString();
                    int count = 0;
                    foreach (char symbol in check_number)
                    {
                        count = check_number.Count(c => c == symbol);
                        if (count == 3)
                        {
                            tripleNumbersCount++;
                            break;
                        }
                    }
                }
                label4.Text = $"Всего чисел с 3 одинаковыми цифрами: {tripleNumbersCount}";

            } catch
            {
                label4.Text = "Не число!";
            }
        }
    }
}
