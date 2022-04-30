namespace C15_DialogBox
{
    partial class Color_DialogBox
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
            this.btn_page2 = new System.Windows.Forms.Button();
            this.lbl_ind1 = new System.Windows.Forms.Label();
            this.btn_color_back = new System.Windows.Forms.Button();
            this.btn_color_fore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_page2
            // 
            this.btn_page2.Location = new System.Drawing.Point(572, 407);
            this.btn_page2.Name = "btn_page2";
            this.btn_page2.Size = new System.Drawing.Size(189, 76);
            this.btn_page2.TabIndex = 3;
            this.btn_page2.Text = "learn  next Dialogbox";
            this.btn_page2.UseVisualStyleBackColor = true;
            this.btn_page2.Click += new System.EventHandler(this.btn_page2_Click);
            // 
            // lbl_ind1
            // 
            this.lbl_ind1.AutoSize = true;
            this.lbl_ind1.Location = new System.Drawing.Point(281, 69);
            this.lbl_ind1.Name = "lbl_ind1";
            this.lbl_ind1.Size = new System.Drawing.Size(38, 17);
            this.lbl_ind1.TabIndex = 4;
            this.lbl_ind1.Text = "India";
            this.lbl_ind1.Click += new System.EventHandler(this.lbl_ind1_Click);
            // 
            // btn_color_back
            // 
            this.btn_color_back.Location = new System.Drawing.Point(202, 155);
            this.btn_color_back.Name = "btn_color_back";
            this.btn_color_back.Size = new System.Drawing.Size(225, 34);
            this.btn_color_back.TabIndex = 5;
            this.btn_color_back.Text = "Color background";
            this.btn_color_back.UseVisualStyleBackColor = true;
            this.btn_color_back.Click += new System.EventHandler(this.btn_color_back_Click);
            // 
            // btn_color_fore
            // 
            this.btn_color_fore.Location = new System.Drawing.Point(202, 195);
            this.btn_color_fore.Name = "btn_color_fore";
            this.btn_color_fore.Size = new System.Drawing.Size(225, 34);
            this.btn_color_fore.TabIndex = 5;
            this.btn_color_fore.Text = "Color Foreground";
            this.btn_color_fore.UseVisualStyleBackColor = true;
            this.btn_color_fore.Click += new System.EventHandler(this.btn_color_fore_Click);
            // 
            // Color_DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 534);
            this.Controls.Add(this.btn_color_fore);
            this.Controls.Add(this.btn_color_back);
            this.Controls.Add(this.lbl_ind1);
            this.Controls.Add(this.btn_page2);
            this.Name = "Color_DialogBox";
            this.Text = "Color_DialogBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_page2;
        private System.Windows.Forms.Label lbl_ind1;
        private System.Windows.Forms.Button btn_color_back;
        private System.Windows.Forms.Button btn_color_fore;
    }
}