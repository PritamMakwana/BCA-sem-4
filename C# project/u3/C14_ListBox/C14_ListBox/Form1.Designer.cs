namespace C14_ListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lst_left = new System.Windows.Forms.ListBox();
            this.lst_right = new System.Windows.Forms.ListBox();
            this.btn_l_r_all = new System.Windows.Forms.Button();
            this.btn_l_r_selected = new System.Windows.Forms.Button();
            this.btn_r_l_all = new System.Windows.Forms.Button();
            this.btn_r_l_selected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(232, 57);
            this.txt_city.Multiline = true;
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(248, 29);
            this.txt_city.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(501, 50);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 36);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lst_left
            // 
            this.lst_left.FormattingEnabled = true;
            this.lst_left.ItemHeight = 16;
            this.lst_left.Location = new System.Drawing.Point(151, 117);
            this.lst_left.Name = "lst_left";
            this.lst_left.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_left.Size = new System.Drawing.Size(143, 276);
            this.lst_left.TabIndex = 3;
            // 
            // lst_right
            // 
            this.lst_right.FormattingEnabled = true;
            this.lst_right.ItemHeight = 16;
            this.lst_right.Location = new System.Drawing.Point(459, 117);
            this.lst_right.Name = "lst_right";
            this.lst_right.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_right.Size = new System.Drawing.Size(150, 276);
            this.lst_right.TabIndex = 3;
            // 
            // btn_l_r_all
            // 
            this.btn_l_r_all.Location = new System.Drawing.Point(319, 117);
            this.btn_l_r_all.Name = "btn_l_r_all";
            this.btn_l_r_all.Size = new System.Drawing.Size(104, 54);
            this.btn_l_r_all.TabIndex = 4;
            this.btn_l_r_all.Text = "All  >";
            this.btn_l_r_all.UseVisualStyleBackColor = true;
            this.btn_l_r_all.Click += new System.EventHandler(this.btn_l_r_all_Click);
            // 
            // btn_l_r_selected
            // 
            this.btn_l_r_selected.Location = new System.Drawing.Point(300, 177);
            this.btn_l_r_selected.Name = "btn_l_r_selected";
            this.btn_l_r_selected.Size = new System.Drawing.Size(144, 37);
            this.btn_l_r_selected.TabIndex = 5;
            this.btn_l_r_selected.Text = "selected >>";
            this.btn_l_r_selected.UseVisualStyleBackColor = true;
            this.btn_l_r_selected.Click += new System.EventHandler(this.btn_l_r_selected_Click);
            // 
            // btn_r_l_all
            // 
            this.btn_r_l_all.Location = new System.Drawing.Point(319, 263);
            this.btn_r_l_all.Name = "btn_r_l_all";
            this.btn_r_l_all.Size = new System.Drawing.Size(104, 54);
            this.btn_r_l_all.TabIndex = 4;
            this.btn_r_l_all.Text = "< All  ";
            this.btn_r_l_all.UseVisualStyleBackColor = true;
            this.btn_r_l_all.Click += new System.EventHandler(this.btn_r_l_all_Click);
            // 
            // btn_r_l_selected
            // 
            this.btn_r_l_selected.Location = new System.Drawing.Point(300, 323);
            this.btn_r_l_selected.Name = "btn_r_l_selected";
            this.btn_r_l_selected.Size = new System.Drawing.Size(144, 37);
            this.btn_r_l_selected.TabIndex = 5;
            this.btn_r_l_selected.Text = "<< selected";
            this.btn_r_l_selected.UseVisualStyleBackColor = true;
            this.btn_r_l_selected.Click += new System.EventHandler(this.btn_r_l_selected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 511);
            this.Controls.Add(this.btn_r_l_selected);
            this.Controls.Add(this.btn_r_l_all);
            this.Controls.Add(this.btn_l_r_selected);
            this.Controls.Add(this.btn_l_r_all);
            this.Controls.Add(this.lst_right);
            this.Controls.Add(this.lst_left);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ListBox ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lst_left;
        private System.Windows.Forms.ListBox lst_right;
        private System.Windows.Forms.Button btn_l_r_all;
        private System.Windows.Forms.Button btn_l_r_selected;
        private System.Windows.Forms.Button btn_r_l_all;
        private System.Windows.Forms.Button btn_r_l_selected;
    }
}

