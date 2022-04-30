using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C16_Message_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_msg_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(" R U SURE ? ", "Alert ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);

            if (d == DialogResult.Yes)
            {
                MessageBox.Show("U have pressed Yes ");
            }else if (d == DialogResult.No ){
                MessageBox.Show("U have pressed No ");
            }

        }
    }
}
