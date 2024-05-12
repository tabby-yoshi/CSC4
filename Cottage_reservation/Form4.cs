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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public String name = "";

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
