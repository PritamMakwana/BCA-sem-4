using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1_Form_1_demo
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

        private void text_fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_fullname_Enter(object sender, EventArgs e)
        {
            text_fullname.Text = text__fname.Text + " " + text_mname.Text + " " + text_lname.Text;
        }


    }
}
