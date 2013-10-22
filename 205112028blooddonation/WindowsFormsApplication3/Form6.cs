using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using  System.Data.OleDb;
namespace WindowsFormsApplication3
{
    public partial class Form6 : Form
    {
      //  OleDbConnection con;
      //  string bgroup;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
       OleDbDataReader dr;
        
      
        
        // string ROLLNO,NAME,ADDRESS,MOBILENO,EMAIL,BGROUP;

        public Form6()
        {
            InitializeComponent();
        }


//      public void passvalue(OleDbConnection conn,string str)
  //      {
    //       con = conn;
      //      bgroup = str;
  //}
       

    

    
  private void button1_Click(object sender, EventArgs e)
  {
      
      try
      {
          
           data.Enabled = true;

          System.Data.OleDb.OleDbConnection MyCnn;

          System.Data.DataSet DSet;

          System.Data.OleDb.OleDbDataAdapter MyCmd;

          MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from reg", con);
          MyCmd.TableMappings.Add("Table", "reg");
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
      Form3 n = new Form3();
      n.Show();
      Hide();
  }

  private void button3_Click(object sender, EventArgs e)
  {
      Hide();

  }

  private void Form6_Load_1(object sender, EventArgs e)
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

  private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {

  }

 

  }
    }

