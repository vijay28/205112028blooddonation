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
    public partial class Form7 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                data.Enabled = true;

                System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;

                System.Data.OleDb.OleDbDataAdapter MyCmd;

                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from registration", con);
                MyCmd.TableMappings.Add("Table", "registration");
                //     com.CommandText = "Delete reg where BGROUP='" + Apositive + "' ";
                //       dr = com.ExecuteReader();
                //     dr.Dispose();

                DSet = new System.Data.DataSet();
                MyCmd.Fill(DSet);
                //   MessageBox.Show("bwfore selection");

                data.DataSource = DSet.Tables[0];
                //  MessageBox.Show("after selection");
                //                con.Close();
                MyCmd.Dispose();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 p = new Form3();
            p.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1228;Password=User201;Data Source=nitt;";


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
    }
}
