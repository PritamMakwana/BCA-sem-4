using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C18_Timer_demo
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
          /*  if (lbl_main.Text == "KAMANI")
                lbl_main.Text = "SCIENCE";
            else
                lbl_main.Text = "KAMANI";
            */
            i = i + timer1.Interval;
            if (i == 1000)
                lbl_main.Text = "SCIENCE";
            else
            {
                lbl_main.Text = "KAMANI";
                i = 0;
            }
                      
            if (lbl_main.BackColor == Color.White)
                lbl_main.BackColor = Color.Yellow;
            else
                lbl_main.BackColor = Color.White;

           
       
           /*if (this.BackColor == Color.Cyan)
                this.BackColor = Color.Black;
            else if (this.BackColor == Color.Black)
                this.BackColor = Color.Yellow;
            else
                this.BackColor = Color.Cyan;
            */
        


        }
        
    }
}
