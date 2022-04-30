using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C20_chackboxes_five
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


        int i = 0;
        Boolean  A, B, C, D, E, F, G, H, I, J;
        private void chk_A_CheckedChanged_1(object sender, EventArgs e)
        {

            if (chk_A.Checked == true)
            {
                i = i + 1;
                A = true;
            }
            else
            {
                i = i - 1;
                A = false;
            }
            con();
            
        }

        private void chk_B_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_B.Checked == true)
            {
                i = i + 1;
                B = true;
            }
            else 
            {
                i = i - 1;
                B = false;
            }
            con();

        }

        private void chk_C_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_C.Checked == true)
            {
                i = i + 1;
                C = true;
            }
            else 
            {
                i = i - 1;
                C = false;
            }
            con();
        }

        private void chk_D_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_D.Checked == true)
            {
                i = i + 1;
                D = true;
            }
            else 
            {
                i = i - 1;
                D = false;
            }
            con();
        }

        private void chk_E_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_E.Checked == true)
            {
                i = i + 1;
                E = true;
            }
            else
            {
                i = i - 1;
                E = false;
            }
            con();
        }

        private void chk_F_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_F.Checked == true)
            {
                i = i + 1;
                F = true;
            }
            else 
            {
                i = i - 1;
                F = false;
            }
            con();

        }

        private void chk_G_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_G.Checked == true)
            {
                i = i + 1;
                G = true;
            }
            else 
            {
                i = i - 1;
                G = false;
            }
            con();
        }

        private void chk_H_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_H.Checked == true)
            {
                i = i + 1;
                H = true;
            }
            else 
            {
                i = i - 1;
                H = false;
            }
            con();
        }

        private void chk_I_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_I.Checked == true)
            {
                i = i + 1;
                I = true;
            }
            else 
            {
                i = i - 1;
                I = false;
            }
            con();
        }

        private void chk_J_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_J.Checked == true)
            {
                i = i + 1;
                J = true;
            }
            else
            {
                i = i - 1;
                J = false;
            }
            con();
        }

        public void dataManage()
        {
            if (A == true)
                chk_A.Enabled = true;
            else
                chk_A.Enabled = false;

            if (B == true)
                chk_B.Enabled = true;
            else
                chk_B.Enabled = false;

            if (C == true)
                chk_C.Enabled = true;
            else
                chk_C.Enabled = false;

            if (D == true)
                chk_D.Enabled = true;
            else
                chk_D.Enabled = false;

            if (E == true)
                chk_E.Enabled = true;
            else
                chk_E.Enabled = false;

            if (F == true)
                chk_F.Enabled = true;
            else
                chk_F.Enabled = false;

            if (G == true)
                chk_G.Enabled = true;
            else
                chk_G.Enabled = false;

            if (H == true)
                chk_H.Enabled = true;
            else
                chk_H.Enabled = false;

            if (I == true)
                chk_I.Enabled = true;
            else
                chk_I.Enabled = false;

            if (J == true)
                chk_J.Enabled = true;
            else
                chk_J.Enabled = false;

        }
        public void setManage()
        {
            chk_A.Enabled = true;
            chk_B.Enabled = true;
            chk_C.Enabled = true;
            chk_D.Enabled = true;
            chk_E.Enabled = true;
            chk_F.Enabled = true;
            chk_G.Enabled = true;
            chk_H.Enabled = true;
            chk_I.Enabled = true;
            chk_J.Enabled = true;
        }
        public void con()
        {
            if (i >= 5)
                dataManage();
            else
                setManage();

        }
       
    }
}
