namespace _1_CRUD_DEMO
{
    partial class Form2
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
            this.btn_regi = new System.Windows.Forms.Button();
            this.txt_n_pass = new System.Windows.Forms.TextBox();
            this.txt_n_unm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_regi
            // 
            this.btn_regi.Location = new System.Drawing.Point(255, 215);
            this.btn_regi.Name = "btn_regi";
            this.btn_regi.Size = new System.Drawing.Size(161, 27);
            this.btn_regi.TabIndex = 7;
            this.btn_regi.Text = "Register";
            this.btn_regi.UseVisualStyleBackColor = true;
            this.btn_regi.Click += new System.EventHandler(this.btn_regi_Click);
            // 
            // txt_n_pass
            // 
            this.txt_n_pass.Location = new System.Drawing.Point(238, 166);
            this.txt_n_pass.Name = "txt_n_pass";
            this.txt_n_pass.Size = new System.Drawing.Size(222, 20);
            this.txt_n_pass.TabIndex = 6;
            // 
            // txt_n_unm
            // 
            this.txt_n_unm.Location = new System.Drawing.Point(238, 124);
            this.txt_n_unm.Name = "txt_n_unm";
            this.txt_n_unm.Size = new System.Drawing.Size(222, 20);
            this.txt_n_unm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New User name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 367);
            this.Controls.Add(this.btn_regi);
            this.Controls.Add(this.txt_n_pass);
            this.Controls.Add(this.txt_n_unm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regi;
        private System.Windows.Forms.TextBox txt_n_pass;
        private System.Windows.Forms.TextBox txt_n_unm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}