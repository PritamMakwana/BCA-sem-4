using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Checkbox_country
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
          String s = " ";
          Boolean ind = false, rus = false, aus = false  ; 
          int ind_no = 1, rus_no = 1,aus_no = 1;
        private void chk_india_CheckedChanged(object sender, EventArgs e)
        {
            String india = chk_india.Text, russia = chk_russia.Text, Australia = chk_australia.Text;

            if (chk_india.Checked == true)
            {
                if (ind_no == 1  && rus == false && aus == false)
                {
                    lbl_data.Text = s + india;
                    ind_no = 1;
                }
                else if (rus_no == 1 && rus == true)
                {
                    if (aus_no == 2 && rus_no == 1)
                    {
                        lbl_data.Text = s + russia + s + Australia + s + india;
                        ind_no = 3;
                    }
                    else
                    {
                        lbl_data.Text = s + russia + s + india;
                        ind_no = 2;
                    }
                }
                else if (aus_no == 1 && aus == true )
                {
                    if (rus_no == 2 && aus_no == 1)
                    {
                        lbl_data.Text = s + Australia + s + russia + s + india;
                        ind_no = 3;
                    }
                    else
                    {
                        lbl_data.Text = s + Australia + s + india;
                        ind_no = 2;
                    }
                }
                ind = true;              
            }
            else
            {
                ind = false;
                if (rus == true && aus == true)
                {
                    if (rus_no == 2 && aus_no == 1)
                    {
                        lbl_data.Text = s + Australia + s + russia;
                        aus_no = 1;
                        rus_no = 2;
                        
                    }
                    {
                        lbl_data.Text = s + russia + s + Australia;
                        aus_no = 2;
                        rus_no = 1;
                    }
                }
                else if (rus == true)
                {
                    lbl_data.Text = s + russia;
                    rus_no = 1;
                }
                else if (aus == true)
                {
                    lbl_data.Text = s + Australia;
                    aus_no = 1;
                }
                else
                {
                    lbl_data.Text = s;
                }
                ind_no = 1;
               
            }
        }

        private void chk_russia_CheckedChanged(object sender, EventArgs e)
        {
            String india = chk_india.Text, russia = chk_russia.Text, Australia = chk_australia.Text;

            if (chk_russia.Checked == true)
            {
                if (rus_no == 1  && ind == false && aus == false)
                {
                    lbl_data.Text = s + russia;
                    rus_no = 1;
                }
                else if (ind_no == 1 && ind == true)
                {

                    if (aus_no == 2 && ind_no == 1)
                    {
                        lbl_data.Text = s + india + s + Australia + s + russia;
                        rus_no = 3;
                    }
                    else
                    {
                        lbl_data.Text = s + india + s + russia;
                        rus_no = 2;
                    }

                }
                else if (aus_no == 1 && aus == true)
                {
                    if (ind_no == 2 && aus_no == 1)
                    {
                        lbl_data.Text = s + Australia + s + india + s + russia;
                        rus_no = 3;
                    }
                    else
                    {

                        lbl_data.Text = s + Australia + s + russia;
                        rus_no = 2;
                    }
                }
                
               
                rus = true;           
            }
            else
            {
                rus = false;
                if (ind == true && aus == true)
                {
                  
                    if(ind_no == 2 && aus_no == 1)
                    {
                       lbl_data.Text = s + Australia + s + india;
                       ind_no = 2;
                       aus_no = 1;
                   }
                    else
                    {
                        lbl_data.Text = s + india + s + Australia;
                        ind_no = 1;
                        aus_no = 2;
                    }                
                }
                
                else if (ind == true)
                {
                    lbl_data.Text = s + india;
                    ind_no = 1;
                }
                else if (aus == true)
                {
                    lbl_data.Text = s + Australia;
                    aus_no = 1;

                }
                else
                {
                    lbl_data.Text = s;
                }
                rus_no = 1;
            }
        }

        private void chk_australia_CheckedChanged(object sender, EventArgs e)
        {
            String india = chk_india.Text, russia = chk_russia.Text, Australia = chk_australia.Text;

            if (chk_australia.Checked == true)
            {
                if (aus_no == 1  && rus == false && ind == false)
                {
                    lbl_data.Text = s + Australia;
                    aus_no = 1;
                }
                else if (ind_no == 1 && ind == true)
                {
                    if (rus_no == 2 && ind_no == 1)
                    {
                        lbl_data.Text = s + india + s + russia + s + Australia;
                        aus_no = 3;
                    }
                    else
                    {
                        lbl_data.Text = s + india + s + Australia;
                        aus_no = 2;
                    }
                }
                else if (rus_no == 1 && rus == true)
                {
                    if (ind_no == 2 && rus_no == 1)
                    {
                        lbl_data.Text = s + russia + s + india + s + Australia;
                        aus_no = 3;
                    }
                    else
                    {
                        lbl_data.Text = s + russia + s + Australia;
                        aus_no = 2;
                    }
                }
                aus = true;
               
            }
            else
            {
                aus = false;
                if (ind == true && rus == true)
                {

                    if (ind_no  == 2 && rus_no == 1)
                    {
                        lbl_data.Text = s + russia + s + india;
                        rus_no = 1;
                        ind_no = 2;
                    }
                    else
                    {
                        lbl_data.Text = s + india + s + russia;
                        rus_no = 2;
                        ind_no = 1;
                    }
                }
                else if (ind == true)
                {
                    lbl_data.Text = s + india;
                    ind_no = 1;
                }
                else if (rus == true)
                {
                    lbl_data.Text = s + russia;
                    rus_no = 1;
                }
                else
                {
                    lbl_data.Text = s;
                }
                aus_no = 1;            
            }
        }



     
    }
}
