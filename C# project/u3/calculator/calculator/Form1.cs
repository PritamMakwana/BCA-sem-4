using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class btn_old_even : Form
    {
        public btn_old_even()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            txt_res.Text = ((Int32.Parse(txt_x.Text)) + (Int32.Parse(txt_y.Text))).ToString(); 
        }

        private void btn_miuns_Click(object sender, EventArgs e)
        {
            txt_res.Text = ((Int32.Parse(txt_x.Text)) - (Int32.Parse(txt_y.Text))).ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            txt_res.Text = ((Int32.Parse(txt_x.Text)) * (Int32.Parse(txt_y.Text))).ToString();
        }

        private void btn_devition_Click(object sender, EventArgs e)
        {
            txt_res.Text = ((Int32.Parse(txt_x.Text)) / (Int32.Parse(txt_y.Text))).ToString();
        }

        private void btn_odd_even_Click(object sender, EventArgs e)
        {
            if( (Int32.Parse(txt_x.Text)) % 2 == 0 &&  (Int32.Parse(txt_y.Text)) % 2 == 0)
            {
                txt_res.Text = "X is even = " + txt_x.Text + " Y is even = " + txt_y.Text;
            }
            else if ((Int32.Parse(txt_x.Text)) % 2 == 0 && (Int32.Parse(txt_y.Text)) % 2 != 0)
            {
                txt_res.Text = "X is even = " + txt_x.Text + " Y is odd = " + txt_y.Text;
            }
            else if ((Int32.Parse(txt_x.Text)) % 2 != 0 && (Int32.Parse(txt_y.Text)) % 2 == 0)
            {
                txt_res.Text = "X is odd = " + txt_x.Text + " Y is even = " + txt_y.Text;
            }
            else if ((Int32.Parse(txt_x.Text)) % 2 != 0 && (Int32.Parse(txt_y.Text)) % 2 != 0)
            {
                txt_res.Text = "X is odd = " + txt_x.Text + " Y is odd = " + txt_y.Text;
            }
        }

        private void btn_max_min_Click(object sender, EventArgs e)
        {
            if ((Int32.Parse(txt_x.Text)) > (Int32.Parse(txt_y.Text)))
            {
                txt_res.Text = "X is big compare Y value  :-  X = " + txt_x.Text + " Y = " + txt_y.Text;
            }
            if ((Int32.Parse(txt_x.Text)) < (Int32.Parse(txt_y.Text)))
            {
                txt_res.Text = "Y is big compare X value  :-  X = " + txt_x.Text + " Y = " + txt_y.Text;
            }
            else
            {
                txt_res.Text = "X and Y Both same value :-  X = " + txt_x.Text + " Y = " + txt_y.Text;
            }
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            String x, y, temp;
            x = txt_x.Text;
            y = txt_y.Text;

            temp = x;
            x = y;
            y = temp;

            txt_res.Text = "After swapping :-  X = " + x + " Y = " + y;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_x.Clear();
            txt_y.Clear();
            txt_res.Clear();
        }

       
       
    }
}
