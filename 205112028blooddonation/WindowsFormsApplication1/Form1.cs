using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
String str = @"server=localhost;database=yourDBname;userid=root;password=yourDBpassword;";
MySqlConnection con = null;
try
{
con = new MySqlConnection(str);
con.Open(); //open the connection
}
catch (MySqlException err) //We will capture and display any MySql errors that will occur
{
Console.WriteLine("Error: " + err.ToString());
}
finally
{
if (con != null)
{
	 con.Close(); //safely close the connection
}
} //remember to safely close the connec
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADDRESS_TextChanged(object sender, EventArgs e)
        {

        }

        private void MOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGROUP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {

        }
    }
}
