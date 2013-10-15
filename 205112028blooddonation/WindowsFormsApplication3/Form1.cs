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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if (USER.Text == "28" & PASS.Text == "12345")
            {

           //     MessageBox.Show("LOGIN SUCCESSFUL");
                Form3 f = new Form3();
                f.Show();
                Hide();
            }
            else
            {
              MessageBox.Show("LOGIN FAILED");
            }
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Show();
            Hide();
           
        }

        private void PASS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
