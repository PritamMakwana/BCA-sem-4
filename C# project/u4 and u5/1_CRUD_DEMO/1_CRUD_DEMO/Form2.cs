using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1_CRUD_DEMO
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //   con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\C# project\1_CRUD_DEMO\1_CRUD_DEMO\userdata.mdf;Integrated Security=True;User Instance=True");

            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\BCA\sem 4\Zpractical\C# project\u4 and u5\1_CRUD_DEMO\1_CRUD_DEMO\userdata.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void btn_regi_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into userTable values('" + txt_n_unm.Text + "','" + txt_n_pass.Text + "')", con);
            cmd.ExecuteNonQuery();
        }


    }
}
