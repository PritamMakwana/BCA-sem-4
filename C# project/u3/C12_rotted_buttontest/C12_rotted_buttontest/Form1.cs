using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C12_rotted_buttontest
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

        private void btn_gm_Click(object sender, EventArgs e)
        {
            string gm = btn_gn.Text;
            string ga = btn_gm.Text;
            string ge = btn_ga.Text;
            string gn = btn_ge.Text;

            btn_gm.Text = gm;
            btn_ga.Text = ga;
            btn_ge.Text = ge;
            btn_gn.Text = gn;

        }

        private void btn_ga_Click(object sender, EventArgs e)
        {
            string gm = btn_gn.Text;
            string ga = btn_gm.Text;
            string ge = btn_ga.Text;
            string gn = btn_ge.Text;

            btn_gm.Text = gm;
            btn_ga.Text = ga;
            btn_ge.Text = ge;
            btn_gn.Text = gn;
        }

        private void btn_ge_Click(object sender, EventArgs e)
        {
            string gm = btn_gn.Text;
            string ga = btn_gm.Text;
            string ge = btn_ga.Text;
            string gn = btn_ge.Text;

            btn_gm.Text = gm;
            btn_ga.Text = ga;
            btn_ge.Text = ge;
            btn_gn.Text = gn;
        }

        private void btn_gn_Click(object sender, EventArgs e)
        {
            string gm = btn_gn.Text;
            string ga = btn_gm.Text;
            string ge = btn_ga.Text;
            string gn = btn_ge.Text;

            btn_gm.Text = gm;
            btn_ga.Text = ga;
            btn_ge.Text = ge;
            btn_gn.Text = gn;
        }
    }
}
