namespace C10_Radio_Button
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
            this.rdo_red = new System.Windows.Forms.RadioButton();
            this.rdo_yellow = new System.Windows.Forms.RadioButton();
            this.rdo_blue = new System.Windows.Forms.RadioButton();
            this.lbl_sel = new System.Windows.Forms.Label();
            this.lbl_sel_1 = new System.Windows.Forms.Label();
            this.rdo_blue1 = new System.Windows.Forms.RadioButton();
            this.rdo_yellow1 = new System.Windows.Forms.RadioButton();
            this.rdo_red1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Example 1";
            // 
            // rdo_red
            // 
            this.rdo_red.AutoSize = true;
            this.rdo_red.Location = new System.Drawing.Point(60, 42);
            this.rdo_red.Name = "rdo_red";
            this.rdo_red.Size = new System.Drawing.Size(45, 17);
            this.rdo_red.TabIndex = 1;
            this.rdo_red.TabStop = true;
            this.rdo_red.Text = "Red";
            this.rdo_red.UseVisualStyleBackColor = true;
            this.rdo_red.CheckedChanged += new System.EventHandler(this.rdo_red_CheckedChanged);
            // 
            // rdo_yellow
            // 
            this.rdo_yellow.AutoSize = true;
            this.rdo_yellow.Location = new System.Drawing.Point(60, 65);
            this.rdo_yellow.Name = "rdo_yellow";
            this.rdo_yellow.Size = new System.Drawing.Size(56, 17);
            this.rdo_yellow.TabIndex = 2;
            this.rdo_yellow.TabStop = true;
            this.rdo_yellow.Text = "Yellow";
            this.rdo_yellow.UseVisualStyleBackColor = true;
            this.rdo_yellow.CheckedChanged += new System.EventHandler(this.rdo_yellow_CheckedChanged);
            // 
            // rdo_blue
            // 
            this.rdo_blue.AutoSize = true;
            this.rdo_blue.Location = new System.Drawing.Point(60, 88);
            this.rdo_blue.Name = "rdo_blue";
            this.rdo_blue.Size = new System.Drawing.Size(46, 17);
            this.rdo_blue.TabIndex = 3;
            this.rdo_blue.Text = "Blue";
            this.rdo_blue.UseVisualStyleBackColor = true;
            this.rdo_blue.CheckedChanged += new System.EventHandler(this.rdo_blue_CheckedChanged);
            // 
            // lbl_sel
            // 
            this.lbl_sel.AutoSize = true;
            this.lbl_sel.Location = new System.Drawing.Point(60, 121);
            this.lbl_sel.Name = "lbl_sel";
            this.lbl_sel.Size = new System.Drawing.Size(103, 13);
            this.lbl_sel.TabIndex = 2;
            this.lbl_sel.Text = "you have selected : ";
            // 
            // lbl_sel_1
            // 
            this.lbl_sel_1.AutoSize = true;
            this.lbl_sel_1.Location = new System.Drawing.Point(60, 291);
            this.lbl_sel_1.Name = "lbl_sel_1";
            this.lbl_sel_1.Size = new System.Drawing.Size(103, 13);
            this.lbl_sel_1.TabIndex = 7;
            this.lbl_sel_1.Text = "you have selected : ";
            // 
            // rdo_blue1
            // 
            this.rdo_blue1.AutoSize = true;
            this.rdo_blue1.Location = new System.Drawing.Point(63, 235);
            this.rdo_blue1.Name = "rdo_blue1";
            this.rdo_blue1.Size = new System.Drawing.Size(46, 17);
            this.rdo_blue1.TabIndex = 6;
            this.rdo_blue1.TabStop = true;
            this.rdo_blue1.Text = "Blue";
            this.rdo_blue1.UseVisualStyleBackColor = true;
            // 
            // rdo_yellow1
            // 
            this.rdo_yellow1.AutoSize = true;
            this.rdo_yellow1.Location = new System.Drawing.Point(63, 212);
            this.rdo_yellow1.Name = "rdo_yellow1";
            this.rdo_yellow1.Size = new System.Drawing.Size(56, 17);
            this.rdo_yellow1.TabIndex = 5;
            this.rdo_yellow1.TabStop = true;
            this.rdo_yellow1.Text = "Yellow";
            this.rdo_yellow1.UseVisualStyleBackColor = true;
            // 
            // rdo_red1
            // 
            this.rdo_red1.AutoSize = true;
            this.rdo_red1.Location = new System.Drawing.Point(63, 189);
            this.rdo_red1.Name = "rdo_red1";
            this.rdo_red1.Size = new System.Drawing.Size(45, 17);
            this.rdo_red1.TabIndex = 4;
            this.rdo_red1.Text = "Red";
            this.rdo_red1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Example 2";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(66, 259);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 8;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(795, 397);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.lbl_sel_1);
            this.Controls.Add(this.rdo_blue1);
            this.Controls.Add(this.rdo_yellow1);
            this.Controls.Add(this.rdo_red1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_sel);
            this.Controls.Add(this.rdo_blue);
            this.Controls.Add(this.rdo_yellow);
            this.Controls.Add(this.rdo_red);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Redio examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_red;
        private System.Windows.Forms.RadioButton rdo_yellow;
        private System.Windows.Forms.RadioButton rdo_blue;
        private System.Windows.Forms.Label lbl_sel;
        private System.Windows.Forms.Label lbl_sel_1;
        private System.Windows.Forms.RadioButton rdo_blue1;
        private System.Windows.Forms.RadioButton rdo_yellow1;
        private System.Windows.Forms.RadioButton rdo_red1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_get;
    }
}

