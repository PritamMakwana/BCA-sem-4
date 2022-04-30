namespace Pizza_Plaza
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_italiam = new System.Windows.Forms.CheckBox();
            this.chk_reguler = new System.Windows.Forms.CheckBox();
            this.chk_pizza_special = new System.Windows.Forms.CheckBox();
            this.lbl_150 = new System.Windows.Forms.Label();
            this.lbl_130 = new System.Windows.Forms.Label();
            this.lbl_180 = new System.Windows.Forms.Label();
            this.lbl_t_ita = new System.Windows.Forms.Label();
            this.lbl_t_reg = new System.Windows.Forms.Label();
            this.lbl_t_psp = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_itaq = new System.Windows.Forms.TextBox();
            this.txt_regq = new System.Windows.Forms.TextBox();
            this.txt_pizspqt = new System.Windows.Forms.TextBox();
            this.chk_parcel = new System.Windows.Forms.CheckBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(346, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Piaza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // chk_italiam
            // 
            this.chk_italiam.AutoSize = true;
            this.chk_italiam.ForeColor = System.Drawing.Color.Blue;
            this.chk_italiam.Location = new System.Drawing.Point(126, 135);
            this.chk_italiam.Name = "chk_italiam";
            this.chk_italiam.Size = new System.Drawing.Size(70, 21);
            this.chk_italiam.TabIndex = 5;
            this.chk_italiam.Text = "Italiam";
            this.chk_italiam.UseVisualStyleBackColor = true;
            this.chk_italiam.CheckedChanged += new System.EventHandler(this.chk_italiam_CheckedChanged);
            // 
            // chk_reguler
            // 
            this.chk_reguler.AutoSize = true;
            this.chk_reguler.ForeColor = System.Drawing.Color.Blue;
            this.chk_reguler.Location = new System.Drawing.Point(126, 175);
            this.chk_reguler.Name = "chk_reguler";
            this.chk_reguler.Size = new System.Drawing.Size(80, 21);
            this.chk_reguler.TabIndex = 6;
            this.chk_reguler.Text = "Reguler";
            this.chk_reguler.UseVisualStyleBackColor = true;
            this.chk_reguler.CheckedChanged += new System.EventHandler(this.chk_reguler_CheckedChanged);
            // 
            // chk_pizza_special
            // 
            this.chk_pizza_special.AutoSize = true;
            this.chk_pizza_special.ForeColor = System.Drawing.Color.Blue;
            this.chk_pizza_special.Location = new System.Drawing.Point(126, 219);
            this.chk_pizza_special.Name = "chk_pizza_special";
            this.chk_pizza_special.Size = new System.Drawing.Size(114, 21);
            this.chk_pizza_special.TabIndex = 7;
            this.chk_pizza_special.Text = "Pizza Special";
            this.chk_pizza_special.UseVisualStyleBackColor = true;
            this.chk_pizza_special.CheckedChanged += new System.EventHandler(this.chk_pizza_special_CheckedChanged);
            // 
            // lbl_150
            // 
            this.lbl_150.AutoSize = true;
            this.lbl_150.Location = new System.Drawing.Point(365, 139);
            this.lbl_150.Name = "lbl_150";
            this.lbl_150.Size = new System.Drawing.Size(32, 17);
            this.lbl_150.TabIndex = 8;
            this.lbl_150.Text = "150";
            // 
            // lbl_130
            // 
            this.lbl_130.AutoSize = true;
            this.lbl_130.Location = new System.Drawing.Point(365, 179);
            this.lbl_130.Name = "lbl_130";
            this.lbl_130.Size = new System.Drawing.Size(32, 17);
            this.lbl_130.TabIndex = 9;
            this.lbl_130.Text = "130";
            // 
            // lbl_180
            // 
            this.lbl_180.AutoSize = true;
            this.lbl_180.Location = new System.Drawing.Point(365, 219);
            this.lbl_180.Name = "lbl_180";
            this.lbl_180.Size = new System.Drawing.Size(32, 17);
            this.lbl_180.TabIndex = 10;
            this.lbl_180.Text = "180";
            // 
            // lbl_t_ita
            // 
            this.lbl_t_ita.AutoSize = true;
            this.lbl_t_ita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_t_ita.Location = new System.Drawing.Point(722, 136);
            this.lbl_t_ita.Name = "lbl_t_ita";
            this.lbl_t_ita.Size = new System.Drawing.Size(0, 17);
            this.lbl_t_ita.TabIndex = 11;
            // 
            // lbl_t_reg
            // 
            this.lbl_t_reg.AutoSize = true;
            this.lbl_t_reg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_t_reg.Location = new System.Drawing.Point(722, 176);
            this.lbl_t_reg.Name = "lbl_t_reg";
            this.lbl_t_reg.Size = new System.Drawing.Size(0, 17);
            this.lbl_t_reg.TabIndex = 12;
            // 
            // lbl_t_psp
            // 
            this.lbl_t_psp.AutoSize = true;
            this.lbl_t_psp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_t_psp.Location = new System.Drawing.Point(722, 220);
            this.lbl_t_psp.Name = "lbl_t_psp";
            this.lbl_t_psp.Size = new System.Drawing.Size(0, 17);
            this.lbl_t_psp.TabIndex = 13;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(524, 298);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(99, 17);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Total Payable ";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(722, 298);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(16, 17);
            this.lbl_total.TabIndex = 15;
            this.lbl_total.Text = "0";
            // 
            // txt_itaq
            // 
            this.txt_itaq.Enabled = false;
            this.txt_itaq.Location = new System.Drawing.Point(527, 133);
            this.txt_itaq.Name = "txt_itaq";
            this.txt_itaq.Size = new System.Drawing.Size(60, 22);
            this.txt_itaq.TabIndex = 1;
            this.txt_itaq.Text = "0";
            // 
            // txt_regq
            // 
            this.txt_regq.Enabled = false;
            this.txt_regq.Location = new System.Drawing.Point(527, 173);
            this.txt_regq.Name = "txt_regq";
            this.txt_regq.Size = new System.Drawing.Size(60, 22);
            this.txt_regq.TabIndex = 2;
            this.txt_regq.Text = "0";
            // 
            // txt_pizspqt
            // 
            this.txt_pizspqt.Enabled = false;
            this.txt_pizspqt.Location = new System.Drawing.Point(527, 219);
            this.txt_pizspqt.Name = "txt_pizspqt";
            this.txt_pizspqt.Size = new System.Drawing.Size(60, 22);
            this.txt_pizspqt.TabIndex = 3;
            this.txt_pizspqt.Text = "0";
            // 
            // chk_parcel
            // 
            this.chk_parcel.AutoSize = true;
            this.chk_parcel.Location = new System.Drawing.Point(230, 294);
            this.chk_parcel.Name = "chk_parcel";
            this.chk_parcel.Size = new System.Drawing.Size(97, 21);
            this.chk_parcel.TabIndex = 19;
            this.chk_parcel.Text = "parcel $10";
            this.chk_parcel.UseVisualStyleBackColor = true;
            this.chk_parcel.CheckedChanged += new System.EventHandler(this.chk_parcel_CheckedChanged);
            // 
            // btn_cal
            // 
            this.btn_cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.ForeColor = System.Drawing.Color.Red;
            this.btn_cal.Location = new System.Drawing.Point(512, 377);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(206, 41);
            this.btn_cal.TabIndex = 20;
            this.btn_cal.Text = "Calculate Bill";
            this.btn_cal.UseVisualStyleBackColor = false;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 715);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.chk_parcel);
            this.Controls.Add(this.txt_pizspqt);
            this.Controls.Add(this.txt_regq);
            this.Controls.Add(this.txt_itaq);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbl_t_psp);
            this.Controls.Add(this.lbl_t_reg);
            this.Controls.Add(this.lbl_t_ita);
            this.Controls.Add(this.lbl_180);
            this.Controls.Add(this.lbl_130);
            this.Controls.Add(this.lbl_150);
            this.Controls.Add(this.chk_pizza_special);
            this.Controls.Add(this.chk_reguler);
            this.Controls.Add(this.chk_italiam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Plaza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_italiam;
        private System.Windows.Forms.CheckBox chk_reguler;
        private System.Windows.Forms.CheckBox chk_pizza_special;
        private System.Windows.Forms.Label lbl_150;
        private System.Windows.Forms.Label lbl_130;
        private System.Windows.Forms.Label lbl_180;
        private System.Windows.Forms.Label lbl_t_ita;
        private System.Windows.Forms.Label lbl_t_reg;
        private System.Windows.Forms.Label lbl_t_psp;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_itaq;
        private System.Windows.Forms.TextBox txt_regq;
        private System.Windows.Forms.TextBox txt_pizspqt;
        private System.Windows.Forms.CheckBox chk_parcel;
        private System.Windows.Forms.Button btn_cal;
    }
}

