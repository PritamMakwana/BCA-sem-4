using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keypress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  if (!(e.KeyChar >= 91 && e.KeyChar <= 116 || e.KeyChar == 8))
            if ((e.KeyChar >= 48 && e.KeyChar <= 57)== true  ) //|| e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

      
    }
}
