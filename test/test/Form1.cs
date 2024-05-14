using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
           
        }

        float n1, n2, s;
        string op;

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            textBox1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBox1.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text);
            op = "+"; 
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text);
            op = "*";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text);
            op = "-";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text);
            op = "/";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            n2 = float.Parse(textBox1.Text);
            if (op == "+") {
                s = n1 + n2;
            }else if (op == "*") {
                s = n1 * n2;
            }else if (op == "-") {
                s = n1 - n2;
            }else if (op == "/") {
                s = n1 / n2;
            }
            textBox1.Text = s.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string st = textBox1.Text;
            textBox1.Text = st.Remove(st.Length - 1);
        }

      

        
       

    }
}
