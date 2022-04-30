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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\C# project\1_CRUD_DEMO\1_CRUD_DEMO\userdata.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from userTable where l_user = '" +txt_unm.Text+" ' and l_password = '"+txt_pass.Text +"' " ,con);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                MessageBox.Show("User name and password not exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }


    }
}
