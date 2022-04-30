using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C11_checkbox_demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chk_carrom_CheckedChanged(object sender, EventArgs e)
        {
            lbl_data.Text = "";
            if (chk_carrom.Checked == true)
            {

                lbl_data.Text = "carrom cheched";
            }
            else
                lbl_data.Text = "carrom uncheched";      
            
       
        }

        private void chk_cricket_CheckedChanged(object sender, EventArgs e)
        {
            lbl_data.Text = "";
            if (chk_cricket.Checked == true)
            {

                lbl_data.Text = "cricket cheched";
            }
            else
                lbl_data.Text = "cricket uncheched";   

        }

        private void chk_hochey_CheckedChanged(object sender, EventArgs e)
        {
            lbl_data.Text = "";
            if (chk_hochey.Checked == true)
            {

                lbl_data.Text = "hochey cheched";
            }
            else
                lbl_data.Text = "hochey uncheched";   

        }








    }
}
