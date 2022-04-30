using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C10_Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //example 1

        string lbldata = "you have selected : ";
        private void rdo_red_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sel.BackColor = Color.Red;
            lbl_sel.Text = lbldata + rdo_red.Text;
        }

        private void rdo_yellow_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sel.BackColor = Color.Yellow;
            lbl_sel.Text = lbldata + rdo_yellow.Text;
        }

        private void rdo_blue_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sel.BackColor = Color.Blue;
            lbl_sel.Text = lbldata + rdo_blue.Text;
        }

        //example 2

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (rdo_red1.Checked == true)
            {
                lbl_sel_1.BackColor = Color.Red;
                lbl_sel_1.Text = lbldata + rdo_red1.Text;

            }
            else if (rdo_yellow1.Checked == true)
            {
                lbl_sel_1.BackColor = Color.Yellow;
                lbl_sel_1.Text = lbldata + rdo_yellow1.Text;

            }
            else if (rdo_blue1.Checked == true)
            {
                lbl_sel_1.BackColor = Color.Blue;
                lbl_sel_1.Text = lbldata + rdo_blue1.Text;

            }

        }

      
    }
}
