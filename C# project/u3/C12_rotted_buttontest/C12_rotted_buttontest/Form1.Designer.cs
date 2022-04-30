namespace C12_rotted_buttontest
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
            this.btn_gm = new System.Windows.Forms.Button();
            this.btn_gn = new System.Windows.Forms.Button();
            this.btn_ge = new System.Windows.Forms.Button();
            this.btn_ga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gm
            // 
            this.btn_gm.Location = new System.Drawing.Point(211, 56);
            this.btn_gm.Name = "btn_gm";
            this.btn_gm.Size = new System.Drawing.Size(75, 23);
            this.btn_gm.TabIndex = 0;
            this.btn_gm.Text = "GM";
            this.btn_gm.UseVisualStyleBackColor = true;
            this.btn_gm.Click += new System.EventHandler(this.btn_gm_Click);
            // 
            // btn_gn
            // 
            this.btn_gn.Location = new System.Drawing.Point(77, 121);
            this.btn_gn.Name = "btn_gn";
            this.btn_gn.Size = new System.Drawing.Size(75, 23);
            this.btn_gn.TabIndex = 0;
            this.btn_gn.Text = "GN";
            this.btn_gn.UseVisualStyleBackColor = true;
            this.btn_gn.Click += new System.EventHandler(this.btn_gn_Click);
            // 
            // btn_ge
            // 
            this.btn_ge.Location = new System.Drawing.Point(211, 207);
            this.btn_ge.Name = "btn_ge";
            this.btn_ge.Size = new System.Drawing.Size(75, 23);
            this.btn_ge.TabIndex = 0;
            this.btn_ge.Text = "GE";
            this.btn_ge.UseVisualStyleBackColor = true;
            this.btn_ge.Click += new System.EventHandler(this.btn_ge_Click);
            // 
            // btn_ga
            // 
            this.btn_ga.Location = new System.Drawing.Point(334, 132);
            this.btn_ga.Name = "btn_ga";
            this.btn_ga.Size = new System.Drawing.Size(75, 23);
            this.btn_ga.TabIndex = 0;
            this.btn_ga.Text = "GA";
            this.btn_ga.UseVisualStyleBackColor = true;
            this.btn_ga.Click += new System.EventHandler(this.btn_ga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 398);
            this.Controls.Add(this.btn_ga);
            this.Controls.Add(this.btn_ge);
            this.Controls.Add(this.btn_gn);
            this.Controls.Add(this.btn_gm);
            this.Name = "Form1";
            this.Text = "Rotted Button Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gm;
        private System.Windows.Forms.Button btn_gn;
        private System.Windows.Forms.Button btn_ge;
        private System.Windows.Forms.Button btn_ga;
    }
}

