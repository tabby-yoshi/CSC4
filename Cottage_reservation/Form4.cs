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


        public string nname;
        public string aaddress;
        public string aage;
        public string bbday;
        public string ccontact;

        public string members;
        public DateTime reservationDate;
        public int totalCottages;
        public bool hasVideoke;
        public int salbabidaQuantity;

        int total;

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            total = (400 * totalCottages) + (100 * salbabidaQuantity);

            if (hasVideoke)
            {
                total += 1000;
            }

            guna2HtmlLabel3.Text = nname;
            guna2HtmlLabel4.Text = aaddress;
            guna2HtmlLabel8.Text = ccontact;
            guna2HtmlLabel10.Text = reservationDate.ToString();

            guna2HtmlLabel12.Text = totalCottages.ToString();
            guna2HtmlLabel14.Text = members.ToString();
            if (hasVideoke) { guna2HtmlLabel18.Text = "Yes"; }
            else { guna2HtmlLabel18.Text = "No"; }
            guna2HtmlLabel16.Text = salbabidaQuantity.ToString();
            guna2HtmlLabel20.Text = "Php" + total.ToString();
        }
    }
}
