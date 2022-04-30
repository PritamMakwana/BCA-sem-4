using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaveFileDialog_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "SAVE FILE DLG";
            sfd.InitialDirectory = "D:";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rtxt_note.SaveFile(sfd.FileName,
                    RichTextBoxStreamType.PlainText);
            }

        }

       
    }
}
