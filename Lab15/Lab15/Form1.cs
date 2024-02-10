using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Lab15
{
    public partial class Form1 : Form
    {
        private double x;
        private double end_x;
        private double x_plus;

        private Font font;
        private Brush brush;
        private Bitmap bitmap;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Лукьянов Виктор Вячеславович 20ОКС1 10 вариант");
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        private void DrawGraph()
        {
            if (x <= end_x)
            {
                float y = (float)(Math.Sin(x) / x);
                PointF point = new PointF((float)x * 50, -y * 50 + pictureBox1.Height / 2);

                graphics.DrawString(".", font, brush, point);

                x += x_plus;
                pictureBox1.Image = bitmap;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 0.1;
            end_x = 4 * Math.PI;
            x_plus = 0.1;

            timer1.Stop();

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                brush = new SolidBrush(fontDialog1.Color);
                bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                graphics = Graphics.FromImage(bitmap);

                graphics.Clear(Color.White);

                timer1.Interval = 50;
                timer1.Start();
            }
        }
    }
}
