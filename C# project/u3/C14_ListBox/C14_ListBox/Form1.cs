using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C14_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean cnt = false;
            for (int i = 0; i < lst_left.Items.Count; i++)
            {
                if (lst_left.Items[i].ToString() == txt_city.Text)
                {
                    cnt = true;
                }
            }
            if(cnt == false ){
                lst_left.Items.Add(txt_city.Text);
                txt_city.Clear();
                txt_city.Focus();
            }
        }

        private void btn_l_r_all_Click(object sender, EventArgs e)

        {

            for(int i = 0; i<lst_left.Items.Count  ; i++)
               lst_right.Items.Add(lst_left.Items[i].ToString());

               lst_left.Items.Clear();
            
        }

        private void btn_l_r_selected_Click(object sender, EventArgs e)
        {
            while(lst_left.SelectedItems.Count > 0 )
            {
              string s = lst_left.SelectedItem.ToString();
                lst_right.Items.Add(s);
                lst_left.Items.Remove(s);
            }
        }

        private void btn_r_l_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_right.Items.Count; i++)
                lst_left.Items.Add(lst_right.Items[i].ToString());

            lst_right.Items.Clear();
        }

        private void btn_r_l_selected_Click(object sender, EventArgs e)
        {
            while (lst_right.SelectedItems.Count > 0)
            {
                string s = lst_right.SelectedItem.ToString();
                lst_left.Items.Add(s);
                lst_right.Items.Remove(s);
            }
        }


       
    }
}
