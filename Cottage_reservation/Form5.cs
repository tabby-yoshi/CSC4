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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            guna2Button2.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int total, pay, change;
            total = Convert.ToInt32(guna2TextBox1.Text);
            pay = Convert.ToInt32(guna2TextBox2.Text);

            change = pay - total;
            guna2TextBox3.Text = change.ToString();

            if (pay < total)
            {
                MessageBox.Show("Insufficient Amount!");
            }
            else
            {
                MessageBox.Show("SUCCESS!");
            }
            guna2Button2.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
