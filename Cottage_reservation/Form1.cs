using Guna.UI2.WinForms;

namespace Cottage_reservation
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}