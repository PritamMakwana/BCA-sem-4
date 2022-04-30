namespace _21_pictureBox_radiobutton
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.rtb_apple = new System.Windows.Forms.RadioButton();
            this.rtb_mango = new System.Windows.Forms.RadioButton();
            this.rtb_graps = new System.Windows.Forms.RadioButton();
            this.btn_watermalon = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(149, 29);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(256, 164);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // rtb_apple
            // 
            this.rtb_apple.AutoSize = true;
            this.rtb_apple.Location = new System.Drawing.Point(149, 222);
            this.rtb_apple.Name = "rtb_apple";
            this.rtb_apple.Size = new System.Drawing.Size(64, 21);
            this.rtb_apple.TabIndex = 1;
            this.rtb_apple.TabStop = true;
            this.rtb_apple.Text = "apple";
            this.rtb_apple.UseVisualStyleBackColor = true;
            this.rtb_apple.CheckedChanged += new System.EventHandler(this.rtb_apple_CheckedChanged);
            // 
            // rtb_mango
            // 
            this.rtb_mango.AutoSize = true;
            this.rtb_mango.Location = new System.Drawing.Point(149, 249);
            this.rtb_mango.Name = "rtb_mango";
            this.rtb_mango.Size = new System.Drawing.Size(72, 21);
            this.rtb_mango.TabIndex = 1;
            this.rtb_mango.TabStop = true;
            this.rtb_mango.Text = "Mango";
            this.rtb_mango.UseVisualStyleBackColor = true;
            this.rtb_mango.CheckedChanged += new System.EventHandler(this.rtb_mango_CheckedChanged);
            // 
            // rtb_graps
            // 
            this.rtb_graps.AutoSize = true;
            this.rtb_graps.Location = new System.Drawing.Point(149, 276);
            this.rtb_graps.Name = "rtb_graps";
            this.rtb_graps.Size = new System.Drawing.Size(65, 21);
            this.rtb_graps.TabIndex = 1;
            this.rtb_graps.TabStop = true;
            this.rtb_graps.Text = "graps";
            this.rtb_graps.UseVisualStyleBackColor = true;
            this.rtb_graps.CheckedChanged += new System.EventHandler(this.rtb_graps_CheckedChanged);
            // 
            // btn_watermalon
            // 
            this.btn_watermalon.AutoSize = true;
            this.btn_watermalon.Location = new System.Drawing.Point(149, 303);
            this.btn_watermalon.Name = "btn_watermalon";
            this.btn_watermalon.Size = new System.Drawing.Size(105, 21);
            this.btn_watermalon.TabIndex = 1;
            this.btn_watermalon.TabStop = true;
            this.btn_watermalon.Text = "Watermalon";
            this.btn_watermalon.UseVisualStyleBackColor = true;
            this.btn_watermalon.CheckedChanged += new System.EventHandler(this.btn_watermalon_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 420);
            this.Controls.Add(this.btn_watermalon);
            this.Controls.Add(this.rtb_graps);
            this.Controls.Add(this.rtb_mango);
            this.Controls.Add(this.rtb_apple);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.RadioButton rtb_apple;
        private System.Windows.Forms.RadioButton rtb_mango;
        private System.Windows.Forms.RadioButton rtb_graps;
        private System.Windows.Forms.RadioButton btn_watermalon;
    }
}

