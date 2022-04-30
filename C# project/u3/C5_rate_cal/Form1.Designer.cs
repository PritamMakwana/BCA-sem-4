namespace C5_rate_cal
{
    partial class S1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_P = new System.Windows.Forms.TextBox();
            this.txt_R = new System.Windows.Forms.TextBox();
            this.txt_N = new System.Windows.Forms.TextBox();
            this.txt_si = new System.Windows.Forms.TextBox();
            this.btn_rate = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "S1";
            // 
            // txt_P
            // 
            this.txt_P.Location = new System.Drawing.Point(103, 64);
            this.txt_P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(132, 22);
            this.txt_P.TabIndex = 1;
            // 
            // txt_R
            // 
            this.txt_R.Enabled = false;
            this.txt_R.Location = new System.Drawing.Point(103, 101);
            this.txt_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_R.Name = "txt_R";
            this.txt_R.Size = new System.Drawing.Size(132, 22);
            this.txt_R.TabIndex = 4;
            // 
            // txt_N
            // 
            this.txt_N.Location = new System.Drawing.Point(101, 134);
            this.txt_N.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_N.Name = "txt_N";
            this.txt_N.Size = new System.Drawing.Size(132, 22);
            this.txt_N.TabIndex = 2;
            // 
            // txt_si
            // 
            this.txt_si.Enabled = false;
            this.txt_si.Location = new System.Drawing.Point(101, 166);
            this.txt_si.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_si.Name = "txt_si";
            this.txt_si.Size = new System.Drawing.Size(132, 22);
            this.txt_si.TabIndex = 4;
            // 
            // btn_rate
            // 
            this.btn_rate.Location = new System.Drawing.Point(260, 101);
            this.btn_rate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rate.Name = "btn_rate";
            this.btn_rate.Size = new System.Drawing.Size(53, 25);
            this.btn_rate.TabIndex = 5;
            this.btn_rate.Text = "DO";
            this.btn_rate.UseVisualStyleBackColor = true;
            this.btn_rate.Click += new System.EventHandler(this.btn_rate_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(163, 212);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(100, 28);
            this.btn_cal.TabIndex = 5;
            this.btn_cal.Text = "calculater";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // S1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(455, 367);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_rate);
            this.Controls.Add(this.txt_si);
            this.Controls.Add(this.txt_N);
            this.Controls.Add(this.txt_R);
            this.Controls.Add(this.txt_P);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "S1";
            this.Text = "SI";
            this.Load += new System.EventHandler(this.S1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_P;
        private System.Windows.Forms.TextBox txt_R;
        private System.Windows.Forms.TextBox txt_N;
        private System.Windows.Forms.TextBox txt_si;
        private System.Windows.Forms.Button btn_rate;
        private System.Windows.Forms.Button btn_cal;
    }
}

