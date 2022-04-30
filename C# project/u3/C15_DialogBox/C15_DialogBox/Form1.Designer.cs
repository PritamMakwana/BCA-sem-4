namespace C15_DialogBox
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
            this.lbl_ind = new System.Windows.Forms.Label();
            this.btn_font = new System.Windows.Forms.Button();
            this.btn_page1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ind
            // 
            this.lbl_ind.AutoSize = true;
            this.lbl_ind.Location = new System.Drawing.Point(187, 73);
            this.lbl_ind.Name = "lbl_ind";
            this.lbl_ind.Size = new System.Drawing.Size(38, 17);
            this.lbl_ind.TabIndex = 0;
            this.lbl_ind.Text = "India";
            // 
            // btn_font
            // 
            this.btn_font.Location = new System.Drawing.Point(157, 145);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(93, 37);
            this.btn_font.TabIndex = 1;
            this.btn_font.Text = "Font";
            this.btn_font.UseVisualStyleBackColor = true;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // btn_page1
            // 
            this.btn_page1.Location = new System.Drawing.Point(473, 336);
            this.btn_page1.Name = "btn_page1";
            this.btn_page1.Size = new System.Drawing.Size(189, 76);
            this.btn_page1.TabIndex = 2;
            this.btn_page1.Text = "learn  next Dialogbox";
            this.btn_page1.UseVisualStyleBackColor = true;
            this.btn_page1.Click += new System.EventHandler(this.btn_page1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 559);
            this.Controls.Add(this.btn_page1);
            this.Controls.Add(this.btn_font);
            this.Controls.Add(this.lbl_ind);
            this.Name = "Form1";
            this.Text = "Font Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ind;
        private System.Windows.Forms.Button btn_font;
        private System.Windows.Forms.Button btn_page1;
    }
}

