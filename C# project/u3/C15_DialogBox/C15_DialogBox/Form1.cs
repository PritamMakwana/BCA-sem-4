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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowEffects = true;
            fd.ShowDialog();
            lbl_ind.Font = fd.Font;
            lbl_ind.ForeColor = fd.Color; 
     
        }

        private void btn_page1_Click(object sender, EventArgs e)
        {
            Color_DialogBox c = new Color_DialogBox();
            c.Show();    
        }
        
    }
}
