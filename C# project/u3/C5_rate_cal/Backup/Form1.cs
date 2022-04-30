using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C5_rate_cal
{
    public partial class S1 : Form
    {
        public S1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_rate_Click(object sender, EventArgs e)
        {   
            int  p = (Int32.Parse(txt_P.Text));
            if (p < 10000)
            {
                txt_R.Text = "5";
            }
            else if (p >= 10000 &&  p <= 20000)
            {
                txt_R.Text = "6";
            }
            else if (p >= 20000 && p<=50000)
            {
                txt_R.Text = "7";
            }
            else if (p >= 50000)
            {
                txt_R.Text = "8";
            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            txt_si.Text = ((Int32.Parse(txt_P.Text)*Int32.Parse(txt_R.Text)*Int32.Parse(txt_N.Text)/100)).ToString();

        }
    }
}
