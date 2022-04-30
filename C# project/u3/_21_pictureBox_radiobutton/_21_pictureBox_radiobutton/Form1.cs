using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21_pictureBox_radiobutton
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

        private void rtb_apple_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Load("D:\\C# project\\photos\\a.jpg");
            viewImage();
        }

        private void rtb_mango_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Load("D:\\C# project\\photos\\m.jpg");
            viewImage();
        }

        private void rtb_graps_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Load("D:\\C# project\\photos\\g.jpg");
            viewImage();
        }

        private void btn_watermalon_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Load("D:\\C# project\\photos\\w.jpg");
            viewImage();
        }

        public void viewImage()
        {
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
