using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_des_billet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtclass.Text == "1") {
                if (txtdes.Text == "london") {
                    txttarrif.Text = "1100 DH";
                }
                else if (txtdes.Text == "Paris")
                {
                    txttarrif.Text = "900 DH";
                }
                else {
                    txttarrif.Text = "740 DH";
                }
            }
            else if (txtclass.Text == "2") {
                if (txtdes.Text == "london")
                {
                    txttarrif.Text = "850 DH";
                }
                else if (txtdes.Text == "Paris")
                {
                    txttarrif.Text = "750 DH";
                }
                else
                {
                    txttarrif.Text = "560 DH";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtclass.Text = "";
            txtdes.Text = "";
            txtnom.Clear();
            txttarrif.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

      
    }
}
