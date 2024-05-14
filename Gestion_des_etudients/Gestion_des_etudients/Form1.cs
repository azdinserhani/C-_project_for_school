using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_des_etudients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clearData()
        {
            numero.Clear();
            prenom.Clear();
            nom.Clear();
            filiere.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || numero.Text == "" || filiere.Text == "")
            {
                MessageBox.Show("please fill all the data", "error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView1.Rows.Add(numero.Text, nom.Text, prenom.Text, filiere.Text);
                MessageBox.Show("added sucsufully", "ajouter");
                clearData();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                dataGridView1.Rows.RemoveAt(e.RowIndex);
             
            
        }
    }
}
