using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openFiledialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:";
            ofd.Filter = "text files | * .txt ; *.java";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            foreach (String fnm in ofd.FileNames)
            {
                MessageBox.Show(fnm);
            }
        }
    }
}
