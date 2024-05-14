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

        private void button1_Click(object sender, EventArgs e)
        {
            numero.Clear();
            prenom.Clear();
            nom.Clear();
            filiere.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.dataGridView1.Rows.Add(numero.Text,nom.Text,prenom.Text,filiere.Text );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDatabaseDataSet.etudients' table. You can move, or remove it, as needed.
            this.etudientsTableAdapter.Fill(this.testDatabaseDataSet.etudients);
            nom.Focus();
            
        }
    }
}
