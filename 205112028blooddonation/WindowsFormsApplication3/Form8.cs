using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 y = new Form6();
            y.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 x = new Form7();
            x.Show();
            Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
