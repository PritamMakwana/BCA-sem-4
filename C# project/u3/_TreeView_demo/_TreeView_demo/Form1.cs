using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _TreeView_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode node;

            node = treeView1.Nodes.Add("Fruits");
            node.Nodes.Add("Apple");
            node.Nodes.Add("mango");

            node = treeView1.Nodes.Add("Vegetebles");
            node.Nodes.Add("Tomato");
            node.Nodes.Add("cacuber");
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btn_Collapse_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            treeView1.Sort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
