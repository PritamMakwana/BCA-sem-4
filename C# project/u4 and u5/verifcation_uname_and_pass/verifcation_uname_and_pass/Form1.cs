using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace verifcation_uname_and_pass
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand comm;
        SqlDataAdapter da;
        DataTable dt;
        int i=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\C# project\u4\verifcation_uname_and_pass\verifcation_uname_and_pass\db_user.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from userTable where uname = '" + txt_name.Text + "' and upass = '" + txt_pass.Text + "'", con);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                i++;
            }
            else
            {
                MessageBox.Show("log in sussfully");
            }

            if (i == 1)
            {
                lbl_mess.Text = "you leave only 2 attent ";
            }
            if (i == 2)
            {
                lbl_mess.Text = "you leave only 1 attent ";
            }
            if (i == 3)
            {
                lbl_mess.Text = "soryy you are miss ";
                txt_name.Hide();
                txt_pass.Hide();
            }

        }

       
    }
}
