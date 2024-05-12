using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cottage_reservation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String connectionString = "server = 127.0.0.1; username = root; password = charlene123; database = cottage_reservation;";

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PreviewPanel.Show();

            label1.Text = FirstName.Text + " " + " " + Middlename.Text + " " + " " + Surname.Text;
            loc.Text = Address.Text;
            BdayLabel.Text = Birthday.Text;
            AgeLabel.Text = txtAge.Text;
            ContactLabel.Text = Contact.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PreviewPanel.Hide();
        }

        private void Birthday_ValueChanged(object sender, EventArgs e)
        {


            DateTime birth = Birthday.Value;
            DateTime now = DateTime.Today;
            int age = now.Year - birth.Year;

            if (birth > now.AddYears(-age))
            {
                age--;
            }
            txtAge.Text = age.ToString();



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PersonalInfo.Show();
        }

        private void Contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.name = FirstName.Text + " " + " " + Middlename.Text + " " + " " + Surname.Text;
            f3.address = Address.Text;
            f3.bday = Birthday.Text;
            f3.age = txtAge.Text;
            f3.contact = Contact.Text;
            f3.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PreviewPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
