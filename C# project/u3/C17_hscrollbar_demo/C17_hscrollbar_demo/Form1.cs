using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_hscrollbar_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hsb_Scroll(object sender, ScrollEventArgs e)
        {
            txt_s.Text = hsb.SmallChange.ToString();
            txt_l.Text = hsb.LargeChange.ToString();
            txt_mn.Text = hsb.Minimum.ToString();
            txt_mx.Text = hsb.Maximum.ToString();
            txt_v.Text = hsb.Value.ToString();
            }
    }
}
