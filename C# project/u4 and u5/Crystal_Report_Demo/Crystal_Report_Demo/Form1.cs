using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Crystal_Report_Demo
{
    public partial class Form1 : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = F:\C# project\u4\OleDb.mdb ");
            con.Open();
        }

       

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand(" insert into cityTable (sid,sname,scity) values('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_city.Text + "')", con);
            cmd.ExecuteNonQuery();
            txt_id.Clear();
            txt_name.Clear();
            txt_city.Clear();
            txt_id.Focus();
        }

        private void btn_cr_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

       
    }
}
