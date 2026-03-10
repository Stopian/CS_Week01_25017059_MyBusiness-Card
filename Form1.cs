using System.Diagnostics;

namespace CS_Week01_25017059_MyBusiness_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Stopian") { UseShellExecute = true });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.image2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
