using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C2_Form_2_demo
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

        private void txt_first_Enter(object sender, EventArgs e)
        {
            txt_first.Text = "welcome";
            txt_second.Text = "by";
        }

        private void txt_first_Leave(object sender, EventArgs e)
        {
            txt_first.Text = "by";
            txt_second.Text = "welcome";

        }
    }
}
