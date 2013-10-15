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
             con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=12345; Unicode=true;";
             try
             {
                 con.Open();
                 if (Convert.ToBoolean(con.State))
                 {
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

            if (RNO.Text  != "" & NAME.Text != "" & ADDRESS.Text != "" & MOB.Text != "" & EMAIL.Text != "" & BGROUP.Text != "")
            {
                str = BGROUP.Text;
                
                com.Connection = con;

                com.CommandText = "insert into registration(RNO,NAME,ADDRESS,MOB,EMAIL,BGROUP) values ('" + RNO.Text + "','" + NAME.Text + "','" + ADDRESS.Text + "','" + MOB.Text + "','" + EMAIL.Text + "','" + BGROUP.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
               // MessageBox.Show("record inserted");
            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }
      /*      com.CommandText = "select count(RNO) into  cnt  from reg where BGROUP=" + BGROUP.Text + "";
            com.ExecuteNonQuery();
            com.Dispose();
            Int32 count = Convert.ToInt32(com.ExecuteScalar());
            MessageBox.Show("a"+ count); 
  */
           // MessageBox.Show("a" + str); 
            com.Connection = con;
            com.CommandText = "select *  from REG where BGROUP='" + str + "' ";

        //    com.CommandText = "select *  from REG where BGROUP='" + .Text + "' ";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                string count1 = Convert.ToString(dr.GetString(1));
                //VEHICLE.Text = "VEHICLE NO IS : "+count1;
                //    string count1 = Convert.ToString(dr.GetString(1));
                //  VEHICLE.Text = "VEHICLE NO IS : "+count1;
                MessageBox.Show(count1);
            }



//            com.CommandText = "select NAME  from reg where BGROUP='" + BGROUP.Text + "'";
        //    dr = com.ExecuteScalar();
        //   string count = Convert.ToString(com.ExecuteScalar());

           // while (dr.Read())
           // {
               // string count1 = Convert.ToString(dr.GetString(1));
             //   NAME.Text = "NAME IS : " + count1;
              //  MessageBox.Show(count); 

            //}

        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Show();
            Hide();
           
        }
        }
    }

