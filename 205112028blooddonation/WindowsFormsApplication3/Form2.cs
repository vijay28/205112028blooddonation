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

    public partial class Form2 : Form
    {
        string str;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Password=User201;Persist Security Info=True;User ID=mca1228;Data Source=nitt;";
             try
             {
                 con.Open();
                 if (Convert.ToBoolean(con.State))
                 {
                     MessageBox.Show("Connection Success");
                 }
             }
             catch
             {
                 MessageBox.Show("Connection Failed");
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void AN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void SUBMIT_Click(object sender, EventArgs e)
        {
            if (RNO.Text != "" & NAME.Text != "" & ADDRESS.Text != "" & MOB.Text != "" & EMAIL.Text != "" & BGROUP.Text != "" )
            {

                com.Connection = con;
                com.CommandText = "insert into reg(RNO,NAME,ADDRESS,MOB,EMAIL,BGROUP) values ('" + RNO.Text + "','" + NAME.Text + "','" + ADDRESS.Text + "','" + MOB.Text + "','" + EMAIL.Text + "','" + BGROUP.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("record inserted");
            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }


        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Show();
            Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 
    }
}
