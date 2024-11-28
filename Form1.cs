namespace Yemek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol31.Hide();
            kontrol21.Hide();
            kontrol11.Show();
            kontrol11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol11.Hide();
            kontrol31.Hide();
            kontrol21.Show();
            kontrol21.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kontrol21.Hide();
            kontrol31.Hide();
            kontrol11.Show();
            kontrol11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrol11.Hide();
            kontrol21.Hide();
            kontrol31.Show();
            kontrol31.BringToFront();
        }
    }
}
