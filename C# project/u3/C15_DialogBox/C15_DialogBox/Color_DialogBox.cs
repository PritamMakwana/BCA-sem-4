using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C15_DialogBox
{
    public partial class Color_DialogBox : Form
    {
        public Color_DialogBox()
        {
            InitializeComponent();
        }

       
        private void btn_color_back_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                lbl_ind1.BackColor = cd.Color;
            }
        }

        private void btn_color_fore_Click(object sender, EventArgs e)
        {
           ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                lbl_ind1.ForeColor = cd.Color;
            }
        }

     

        private void btn_page2_Click(object sender, EventArgs e)
        {
            OpenFileDialog_demo op = new OpenFileDialog_demo();
            op.Show();
        }

    
      
    }
}
