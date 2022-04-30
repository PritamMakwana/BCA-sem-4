namespace C1_Form_1_demo
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
            this.lablel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text__fname = new System.Windows.Forms.TextBox();
            this.text_mname = new System.Windows.Forms.TextBox();
            this.text_lname = new System.Windows.Forms.TextBox();
            this.text_fullname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lablel1
            // 
            this.lablel1.AutoSize = true;
            this.lablel1.Location = new System.Drawing.Point(112, 69);
            this.lablel1.Name = "lablel1";
            this.lablel1.Size = new System.Drawing.Size(51, 17);
            this.lablel1.TabIndex = 0;
            this.lablel1.Text = "Fname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full name";
            // 
            // text__fname
            // 
            this.text__fname.Location = new System.Drawing.Point(179, 69);
            this.text__fname.Name = "text__fname";
            this.text__fname.Size = new System.Drawing.Size(250, 22);
            this.text__fname.TabIndex = 4;
            // 
            // text_mname
            // 
            this.text_mname.Location = new System.Drawing.Point(179, 107);
            this.text_mname.Name = "text_mname";
            this.text_mname.Size = new System.Drawing.Size(250, 22);
            this.text_mname.TabIndex = 4;
            // 
            // text_lname
            // 
            this.text_lname.Location = new System.Drawing.Point(179, 147);
            this.text_lname.Name = "text_lname";
            this.text_lname.Size = new System.Drawing.Size(250, 22);
            this.text_lname.TabIndex = 4;
            // 
            // text_fullname
            // 
            this.text_fullname.Location = new System.Drawing.Point(179, 185);
            this.text_fullname.Name = "text_fullname";
            this.text_fullname.ReadOnly = true;
            this.text_fullname.Size = new System.Drawing.Size(471, 22);
            this.text_fullname.TabIndex = 4;
            this.text_fullname.TextChanged += new System.EventHandler(this.text_fullname_TextChanged);
            this.text_fullname.Enter += new System.EventHandler(this.text_fullname_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 269);
            this.Controls.Add(this.text_fullname);
            this.Controls.Add(this.text_lname);
            this.Controls.Add(this.text_mname);
            this.Controls.Add(this.text__fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lablel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text__fname;
        private System.Windows.Forms.TextBox text_mname;
        private System.Windows.Forms.TextBox text_lname;
        private System.Windows.Forms.TextBox text_fullname;
    }
}

