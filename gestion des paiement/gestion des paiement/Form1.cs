using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_des_paiement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string name;
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qualif = comboBox1.Text;
            
            switch (qualif)
            {
                case "inginier":
                    textBox4.Text = "700";
                    break;
                case "technicien S":
                    textBox4.Text = "300";
                    break;
                case "technician":
                    textBox4.Text = "150";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int th = int.Parse(textBox4.Text);
            int nombreH = int.Parse(textBox5.Text);
            int r = th * nombreH;
            textBox6.Text = r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";

        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        private void affButton_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            Form3 form3 = new Form3();
            form3.Tag = this;
            form3.Show(this);
            Hide();
        }


        

        

        
        
     
    }
}
