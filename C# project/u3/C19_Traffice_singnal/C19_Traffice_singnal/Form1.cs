using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C19_Traffice_singnal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                lbl_stop.Visible = false;
                lbl_wait.Visible = false;
                lbl_strat.BackColor = Color.Lime;
                lbl_strat.ForeColor = Color.White;
                lbl_strat.Visible = true;
                lbl_status.Text = "START";
                lbl_status.ForeColor = Color.Lime;
                i = 1;
            }
            else if (i == 1)
            {
                lbl_stop.Visible = false;
                lbl_strat.Visible = false;
                lbl_wait.BackColor = Color.Yellow;
                lbl_wait.ForeColor = Color.White;
                lbl_wait.Visible = true;
                lbl_status.Text = "WAIT";
                lbl_status.ForeColor = Color.Yellow;
                i = 2;
            }
            else
            {
                lbl_strat.Visible = false;
                lbl_wait.Visible = false;
                lbl_stop.BackColor = Color.Red;
                lbl_stop.ForeColor = Color.White;
                lbl_stop.Visible = true;
                lbl_status.Text = "STOP";
                lbl_status.ForeColor = Color.Red;
                i = 0;
            }
      
       }

        private void btn_on_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lbl_strat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
