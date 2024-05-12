﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //nasa form 3 tayo, eto yung mga public variables na i aaccess naten sa form2.
        public string name;
        public string address;
        public string age;
        public string bday;
        public string contact;

        //other pub. variables
        public bool hasvid = false;
        public string numOfSalbabida;




        private void Form3_Load(object sender, EventArgs e)
        {
            guna2Panel2.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel2.Show();
            guna2HtmlLabel6.Text = guna2NumericUpDown1.Value.ToString();

            if (guna2NumericUpDown1.Value == 0)
            {
                MessageBox.Show("Please input valid members");
            }
            else if (guna2NumericUpDown1.Value <= 10)
            {
                guna2HtmlLabel5.Text = "1";
            }
            else if (guna2NumericUpDown1.Value > 10 && guna2NumericUpDown1.Value <= 20)
            {
                guna2HtmlLabel5.Text = "2";
            }
            else if (guna2NumericUpDown1.Value > 20 && guna2NumericUpDown1.Value <= 30)
            {
                guna2HtmlLabel5.Text = "3";
            }
            else if (guna2NumericUpDown1.Value > 30 && guna2NumericUpDown1.Value <= 40)
            {
                guna2HtmlLabel5.Text = "4";
            }
            else if (guna2NumericUpDown1.Value > 40 && guna2NumericUpDown1.Value <= 50)
            {
                guna2HtmlLabel5.Text = "5";
            }
            else if (guna2NumericUpDown1.Value > 50 && guna2NumericUpDown1.Value <= 60)
            {
                guna2HtmlLabel5.Text = "6";
            }
            else if (guna2NumericUpDown1.Value > 60 && guna2NumericUpDown1.Value <= 70)
            {
                guna2HtmlLabel5.Text = "7";
            }
            else if (guna2NumericUpDown1.Value > 70 && guna2NumericUpDown1.Value <= 80)
            {
                guna2HtmlLabel5.Text = "8";
            }
            else if (guna2NumericUpDown1.Value > 80 && guna2NumericUpDown1.Value <= 90)
            {
                guna2HtmlLabel5.Text = "9";
            }
            else if (guna2NumericUpDown1.Value > 90 && guna2NumericUpDown1.Value == 100)
            {
                guna2HtmlLabel5.Text = "10";
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Success!");

            Form4 f4 = new Form4();

            f4.nname = name;
            f4.aaddress = address;
            f4.bbday = bday;
            f4.aage = age;
            f4.ccontact = contact;

            f4.members = guna2NumericUpDown1.Value.ToString();
            f4.reservationDate = guna2DateTimePicker1.Value;
            f4.totalCottages = int.Parse(guna2HtmlLabel5.Text);
            f4.hasVideoke = hasvid;
            f4.salbabidaQuantity = int.Parse(numOfSalbabida);
            f4.ShowDialog();

            this.Show();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            hasvid = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            numOfSalbabida = guna2NumericUpDown2.Value.ToString();
        }
    }
}
