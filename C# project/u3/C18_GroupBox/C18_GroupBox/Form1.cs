using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C18_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (rdb_male.Checked == true)        
                txt_gen.Text = "male";

            else if (rbt_female.Checked == true)
                txt_gen.Text = "female";
            else
                txt_gen.Text = "please select gender !";


            if (rbt_gen.Checked == true)
                txt_cat.Text = "Gender";
            else if (rbt_obc.Checked == true)
                txt_cat.Text = "OBC";
            else if (rbt_sc.Checked == true)
                txt_cat.Text = "SC";
            else if (rbt_st.Checked == true)
                txt_cat.Text = "ST";
            else
                txt_cat.Text = "please select Gender";
            

        }

      
    }
}
