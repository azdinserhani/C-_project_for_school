using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tp_textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text +" "+textBox2.Text);
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(1, textBox1.Text + " " + textBox2.Text);
        }

        
    }
}
