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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            }
            else {
                DialogResult res = MessageBox.Show("Username or password is incorrect ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                
            }
            
        }

        




    }
}
