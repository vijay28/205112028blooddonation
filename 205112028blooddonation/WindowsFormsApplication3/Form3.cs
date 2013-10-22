using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void DONAR_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void RECIPIENT_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Response.Clear();
           Hide();



        }

       

        private void CHOICE_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form8 z = new Form8();
            z.Show();
            Hide();

        }
    }
}
