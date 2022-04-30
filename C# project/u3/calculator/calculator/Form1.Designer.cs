namespace calculator
{
    partial class btn_old_even
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_miuns = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_devition = new System.Windows.Forms.Button();
            this.btn_odd_even = new System.Windows.Forms.Button();
            this.btn_max_min = new System.Windows.Forms.Button();
            this.btn_swap = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANS";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(120, 23);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(245, 22);
            this.txt_x.TabIndex = 1;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(120, 58);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(245, 22);
            this.txt_y.TabIndex = 2;
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(120, 98);
            this.txt_res.Name = "txt_res";
            this.txt_res.ReadOnly = true;
            this.txt_res.Size = new System.Drawing.Size(430, 22);
            this.txt_res.TabIndex = 3;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(138, 157);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(45, 35);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_miuns
            // 
            this.btn_miuns.Location = new System.Drawing.Point(189, 157);
            this.btn_miuns.Name = "btn_miuns";
            this.btn_miuns.Size = new System.Drawing.Size(43, 35);
            this.btn_miuns.TabIndex = 5;
            this.btn_miuns.Text = "-";
            this.btn_miuns.UseVisualStyleBackColor = true;
            this.btn_miuns.Click += new System.EventHandler(this.btn_miuns_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(238, 157);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(46, 35);
            this.btn_mul.TabIndex = 6;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_devition
            // 
            this.btn_devition.Location = new System.Drawing.Point(290, 157);
            this.btn_devition.Name = "btn_devition";
            this.btn_devition.Size = new System.Drawing.Size(43, 35);
            this.btn_devition.TabIndex = 7;
            this.btn_devition.Text = "÷";
            this.btn_devition.UseVisualStyleBackColor = true;
            this.btn_devition.Click += new System.EventHandler(this.btn_devition_Click);
            // 
            // btn_odd_even
            // 
            this.btn_odd_even.Location = new System.Drawing.Point(107, 212);
            this.btn_odd_even.Name = "btn_odd_even";
            this.btn_odd_even.Size = new System.Drawing.Size(108, 34);
            this.btn_odd_even.TabIndex = 8;
            this.btn_odd_even.Text = "odd - even";
            this.btn_odd_even.UseVisualStyleBackColor = true;
            this.btn_odd_even.Click += new System.EventHandler(this.btn_odd_even_Click);
            // 
            // btn_max_min
            // 
            this.btn_max_min.Location = new System.Drawing.Point(221, 213);
            this.btn_max_min.Name = "btn_max_min";
            this.btn_max_min.Size = new System.Drawing.Size(92, 33);
            this.btn_max_min.TabIndex = 9;
            this.btn_max_min.Text = "Max  - Min";
            this.btn_max_min.UseVisualStyleBackColor = true;
            this.btn_max_min.Click += new System.EventHandler(this.btn_max_min_Click);
            // 
            // btn_swap
            // 
            this.btn_swap.Location = new System.Drawing.Point(319, 213);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(88, 34);
            this.btn_swap.TabIndex = 10;
            this.btn_swap.Text = "swap";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(221, 261);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(92, 34);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_old_even
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 468);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_swap);
            this.Controls.Add(this.btn_max_min);
            this.Controls.Add(this.btn_odd_even);
            this.Controls.Add(this.btn_devition);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_miuns);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btn_old_even";
            this.Text = "odd - even";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_miuns;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_devition;
        private System.Windows.Forms.Button btn_odd_even;
        private System.Windows.Forms.Button btn_max_min;
        private System.Windows.Forms.Button btn_swap;
        private System.Windows.Forms.Button btn_clear;
    }
}

