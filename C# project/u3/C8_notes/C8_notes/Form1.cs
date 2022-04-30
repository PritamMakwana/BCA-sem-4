using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C8_notes
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

        private void btn_copy_Click(object sender, EventArgs e)
        {
            txt_f.Copy();

        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            txt_f.Cut();
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            txt_s.Paste();
        }

        private void btn_append_Click(object sender, EventArgs e)
        {
            txt_s.AppendText(txt_f.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_f.Clear();
            txt_s.Clear();
        }

       
    }
}
