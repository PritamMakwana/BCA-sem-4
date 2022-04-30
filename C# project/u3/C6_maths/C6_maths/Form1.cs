using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C6_maths
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

        private void txt_sign_TextChanged(object sender, EventArgs e)
        {
            String sign = txt_sign.Text;
            String ans;
            int x = Int32.Parse(txt_x.Text), y = Int32.Parse(txt_y.Text);

            switch (sign)
            {
                    case "+":
                     ans = (x + y).ToString();
                    break;
                    case "-":
                    ans = (x - y).ToString();
                    break;
                    case "*":
                    ans = (x * y).ToString();
                    break;
                    case "/":
                     ans = (x / y).ToString();
                    break;
                    default:
                    ans = "please valid input sign ";
                    break;
            }

            txt_ans.Text = ans;

        }
    }
}
