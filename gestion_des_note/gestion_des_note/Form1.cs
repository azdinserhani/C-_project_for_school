using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_des_note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float m = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text))/3;
            textBox4.Text = m.ToString();
            if (m >= 10)
            {
                textBox5.Text = "Admi";
            }else {
                textBox5.Text = "non admi";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void hhhhh_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
