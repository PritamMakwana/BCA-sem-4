using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C9_marksheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            Boolean space = false;

       
                if (txt_rollno.Text == "")
                {
                    space = true;
                    txt_rollno.Focus();
                }
                else if (txt_name.Text == "")
                {
                    space = true;
                    txt_name.Focus();
                }
                else if (txt_java.Text == "")
                {
                    space = true;
                    txt_java.Focus();
                }
                else if (txt_csharp.Text == "")
                {
                    space = true;
                    txt_csharp.Focus();
                }
                else if (txt_os.Text == "")
                {
                    space = true;
                    txt_os.Focus();
                }
                else if (txt_net.Text == "")
                {
                    space = true;
                    txt_net.Focus();
                }
   

            if (space == false)
            {

                int total,pre;

                total = (Int32.Parse(txt_java.Text) + Int32.Parse(txt_csharp.Text)
                    + Int32.Parse(txt_net.Text) + Int32.Parse(txt_os.Text));
                txt_obtained.Text = total.ToString();

                pre = total / 4;
                txt_per.Text = pre.ToString() + "%";

                if (pre >= 85)
                {
                    txt_grade.Text = "A";
                }
                else if (pre >= 70)
                {
                    txt_grade.Text = "B";
                }
                else if (pre >= 50)
                {
                    txt_grade.Text = "C";
                }
                else
                {
                    txt_grade.Text = "D";
                }

            }
         
        }

      
    }
}
