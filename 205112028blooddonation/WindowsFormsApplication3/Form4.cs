using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


//using System.Data.Common;
namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        string str;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1228;Password=User201;Data Source=nitt;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                  //  data.Enabled = false;
                    //MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {





            if (RNO.Text != "" & NAME.Text != "" & ADDRESS.Text != "" & MOB.Text != "" & EMAIL.Text != "" & BGROUP.Text != "")
            {
                str = BGROUP.Text;

                com.Connection = con;

                com.CommandText = "insert into registration(RNO,NAME,ADDRESS,MOB,EMAIL,BGROUP) values ('" + RNO.Text + "','" + NAME.Text + "','" + ADDRESS.Text + "','" + MOB.Text + "','" + EMAIL.Text + "','" + BGROUP.Text + "')";
                com.ExecuteNonQuery();
      //          com.Dispose();
                // MessageBox.Show("record inserted");
            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }
//            /*      com.CommandText = "select count(RNO) into  cnt  from reg where BGROUP=" + BGROUP.Text + "";
            //com.Connection = con;

           // com.CommandText = "select *  from REG where BGROUP='" + str + "' ";



            Form5 ob = new Form5();
            ob.passvalue(con, str);
            ob.Show();
            Hide();




           
             
          //  Session.Add("BGROUP", str);


        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            
            c.Show();
            Hide();

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
