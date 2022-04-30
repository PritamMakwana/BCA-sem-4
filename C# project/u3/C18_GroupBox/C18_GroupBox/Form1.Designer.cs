namespace C18_GroupBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_gender = new System.Windows.Forms.GroupBox();
            this.rbt_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.grp_category = new System.Windows.Forms.GroupBox();
            this.rbt_obc = new System.Windows.Forms.RadioButton();
            this.rbt_gen = new System.Windows.Forms.RadioButton();
            this.rbt_sc = new System.Windows.Forms.RadioButton();
            this.rbt_st = new System.Windows.Forms.RadioButton();
            this.btn_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gen = new System.Windows.Forms.TextBox();
            this.txt_cat = new System.Windows.Forms.TextBox();
            this.grp_gender.SuspendLayout();
            this.grp_category.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_gender
            // 
            this.grp_gender.Controls.Add(this.rbt_female);
            this.grp_gender.Controls.Add(this.rdb_male);
            this.grp_gender.Location = new System.Drawing.Point(104, 72);
            this.grp_gender.Name = "grp_gender";
            this.grp_gender.Size = new System.Drawing.Size(297, 290);
            this.grp_gender.TabIndex = 0;
            this.grp_gender.TabStop = false;
            this.grp_gender.Text = "Gender";
            // 
            // rbt_female
            // 
            this.rbt_female.AutoSize = true;
            this.rbt_female.Location = new System.Drawing.Point(30, 103);
            this.rbt_female.Name = "rbt_female";
            this.rbt_female.Size = new System.Drawing.Size(75, 21);
            this.rbt_female.TabIndex = 3;
            this.rbt_female.TabStop = true;
            this.rbt_female.Text = "Female";
            this.rbt_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(30, 59);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(59, 21);
            this.rdb_male.TabIndex = 2;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "male";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // grp_category
            // 
            this.grp_category.Controls.Add(this.rbt_obc);
            this.grp_category.Controls.Add(this.rbt_gen);
            this.grp_category.Controls.Add(this.rbt_sc);
            this.grp_category.Controls.Add(this.rbt_st);
            this.grp_category.Location = new System.Drawing.Point(536, 72);
            this.grp_category.Name = "grp_category";
            this.grp_category.Size = new System.Drawing.Size(304, 290);
            this.grp_category.TabIndex = 1;
            this.grp_category.TabStop = false;
            this.grp_category.Text = "Category";
            // 
            // rbt_obc
            // 
            this.rbt_obc.AutoSize = true;
            this.rbt_obc.Location = new System.Drawing.Point(42, 59);
            this.rbt_obc.Name = "rbt_obc";
            this.rbt_obc.Size = new System.Drawing.Size(58, 21);
            this.rbt_obc.TabIndex = 5;
            this.rbt_obc.TabStop = true;
            this.rbt_obc.Text = "OBC";
            this.rbt_obc.UseVisualStyleBackColor = true;
            // 
            // rbt_gen
            // 
            this.rbt_gen.AutoSize = true;
            this.rbt_gen.Location = new System.Drawing.Point(41, 32);
            this.rbt_gen.Name = "rbt_gen";
            this.rbt_gen.Size = new System.Drawing.Size(77, 21);
            this.rbt_gen.TabIndex = 4;
            this.rbt_gen.TabStop = true;
            this.rbt_gen.Text = "Gender";
            this.rbt_gen.UseVisualStyleBackColor = true;
            // 
            // rbt_sc
            // 
            this.rbt_sc.AutoSize = true;
            this.rbt_sc.Location = new System.Drawing.Point(41, 88);
            this.rbt_sc.Name = "rbt_sc";
            this.rbt_sc.Size = new System.Drawing.Size(47, 21);
            this.rbt_sc.TabIndex = 6;
            this.rbt_sc.TabStop = true;
            this.rbt_sc.Text = "SC";
            this.rbt_sc.UseVisualStyleBackColor = true;
            // 
            // rbt_st
            // 
            this.rbt_st.AutoSize = true;
            this.rbt_st.Location = new System.Drawing.Point(42, 115);
            this.rbt_st.Name = "rbt_st";
            this.rbt_st.Size = new System.Drawing.Size(47, 21);
            this.rbt_st.TabIndex = 7;
            this.rbt_st.TabStop = true;
            this.rbt_st.Text = "ST";
            this.rbt_st.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(427, 397);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(108, 55);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "U R :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "and Categoty :";
            // 
            // txt_gen
            // 
            this.txt_gen.Location = new System.Drawing.Point(354, 478);
            this.txt_gen.Name = "txt_gen";
            this.txt_gen.Size = new System.Drawing.Size(151, 22);
            this.txt_gen.TabIndex = 10;
            // 
            // txt_cat
            // 
            this.txt_cat.Location = new System.Drawing.Point(680, 478);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(151, 22);
            this.txt_cat.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 712);
            this.Controls.Add(this.txt_cat);
            this.Controls.Add(this.txt_gen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.grp_category);
            this.Controls.Add(this.grp_gender);
            this.Name = "Form1";
            this.Text = "GroupBox";
            this.grp_gender.ResumeLayout(false);
            this.grp_gender.PerformLayout();
            this.grp_category.ResumeLayout(false);
            this.grp_category.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_gender;
        private System.Windows.Forms.GroupBox grp_category;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.RadioButton rbt_female;
        private System.Windows.Forms.RadioButton rbt_gen;
        private System.Windows.Forms.RadioButton rbt_obc;
        private System.Windows.Forms.RadioButton rbt_sc;
        private System.Windows.Forms.RadioButton rbt_st;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gen;
        private System.Windows.Forms.TextBox txt_cat;
    }
}

