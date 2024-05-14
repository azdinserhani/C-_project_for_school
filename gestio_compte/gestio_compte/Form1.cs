using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestio_compte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float solde = float.Parse(textBox4.Text);
            float mont = float.Parse(textBox3.Text);
            string choix = comboBox1.Text;
            textBox4.Clear();
            if (choix == "virement")
            {
                solde += mont;
                textBox4.Text = solde.ToString();
            }
            else if (choix == "retrait")
            {
                solde -= mont;
                textBox4.Text = solde.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
        }
    }
}
