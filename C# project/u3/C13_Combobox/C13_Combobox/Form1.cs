using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C13_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (cmb_city.Items.Contains(txt_city.Text) == false)
            {
                cmb_city.Items.Add(txt_city.Text);
                txt_city.Text = " ";
                lbl_info.Text = "Result : Added new city ";
                txt_city.Focus();
            }
            else
            {
                lbl_info.Text = "Result :" + txt_city.Text + " city already exist ";
            }

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            cmb_city.Items.Remove(cmb_city.Text);
        }

       
    }
}
