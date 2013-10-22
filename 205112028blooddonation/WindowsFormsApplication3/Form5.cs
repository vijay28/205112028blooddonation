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
    public partial class Form5 : Form
    {
        OleDbConnection con;
        string bgroup;

        public Form5()
        {
            InitializeComponent();
        }


        public void passvalue(OleDbConnection conn,string str)
        {
            con = conn;
            bgroup = str;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           

            try
            {
                // data.Enabled = true;

                //System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;

                System.Data.OleDb.OleDbDataAdapter MyCmd;


                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from registration where BGROUP='" + (bgroup) + "'", con);

                MyCmd.TableMappings.Add("Table", "registration");

                DSet = new System.Data.DataSet();

                MyCmd.Fill(DSet);

                data.DataSource = DSet.Tables[0];

                //                con.Close();
                MyCmd.Dispose();
                /*   Form5 d = new Form5();
                   d.Show();
                   Hide();
               */
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
