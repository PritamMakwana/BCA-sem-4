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
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //   con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\C# project\1_CRUD_DEMO\1_CRUD_DEMO\userdata.mdf;Integrated Security=True;User Instance=True");

            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\BCA\sem 4\Zpractical\C# project\u4 and u5\1_CRUD_DEMO\1_CRUD_DEMO\userdata.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }

        private void btn_serach_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from  userTable where l_id = " + txt_uid.Text + "  ", con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_uname.Text = dt.Rows[0][0].ToString();
                txt_upass.Text = dt.Rows[0]["l_password"].ToString();
            }
            else
            {
                MessageBox.Show("Not data found for ID = " + txt_uid.Text); 
                txt_uid.Text = "";
                txt_uname.Text = "";
                txt_upass.Text = "";
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update userTable set l_user= ' " +txt_uname.Text+" ', l_password = ' " +txt_upass.Text +"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
            txt_uid.Text = "";
            txt_uname.Text = "";
            txt_upass.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from userTable where l_id=  " + txt_uid.Text + " ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deteted");
            txt_uid.Text = "";
            txt_uname.Text = "";
            txt_upass.Text = "";

        }

       
    }
}
