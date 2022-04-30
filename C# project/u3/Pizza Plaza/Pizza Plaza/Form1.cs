using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Plaza
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

        Boolean order = false;
        private void chk_italiam_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_italiam.Checked == true)
            {
                txt_itaq.Enabled = true;
                order = true;
            }

        }

        private void chk_reguler_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_reguler.Checked == true)
            {
                txt_regq.Enabled = true;
                order = true;
            }
        }

        private void chk_pizza_special_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pizza_special.Checked == true)
            {
                txt_pizspqt.Enabled = true;
                order = true;
            }
        }

        private void chk_parcel_CheckedChanged(object sender, EventArgs e)
        {
            if (order == true)
            {
                if (chk_parcel.Checked == true)
                {
                    int total = (Int32.Parse(lbl_total.Text)) + 10;
                    lbl_total.Text = total.ToString();
                }
                if (chk_parcel.Checked == false)
                {
                    int total = (Int32.Parse(lbl_total.Text)) - 10;
                    lbl_total.Text = total.ToString();
                }
            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {

            int Itali, Regu, Pizzasp ,Fulltotal;

            Itali = Int32.Parse(txt_itaq.Text) * 150 ;
            Regu = Int32.Parse(txt_regq.Text) * 130 ;
            Pizzasp = Int32.Parse(txt_pizspqt.Text) * 180;

            lbl_t_ita.Text = Itali.ToString();
            lbl_t_reg.Text = Regu.ToString();
            lbl_t_psp.Text = Pizzasp.ToString();

            Fulltotal = Itali + Regu + Pizzasp ;
            lbl_total.Text = Fulltotal.ToString();
           
        }
    }
}
