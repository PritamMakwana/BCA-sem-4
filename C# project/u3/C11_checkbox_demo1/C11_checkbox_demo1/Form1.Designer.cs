namespace C11_checkbox_demo1
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
            this.chk_carrom = new System.Windows.Forms.CheckBox();
            this.chk_cricket = new System.Windows.Forms.CheckBox();
            this.chk_hochey = new System.Windows.Forms.CheckBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_carrom
            // 
            this.chk_carrom.AutoSize = true;
            this.chk_carrom.Location = new System.Drawing.Point(113, 40);
            this.chk_carrom.Name = "chk_carrom";
            this.chk_carrom.Size = new System.Drawing.Size(74, 21);
            this.chk_carrom.TabIndex = 0;
            this.chk_carrom.Text = "carrom";
            this.chk_carrom.UseVisualStyleBackColor = true;
            this.chk_carrom.CheckedChanged += new System.EventHandler(this.chk_carrom_CheckedChanged);
            // 
            // chk_cricket
            // 
            this.chk_cricket.AutoSize = true;
            this.chk_cricket.Location = new System.Drawing.Point(113, 67);
            this.chk_cricket.Name = "chk_cricket";
            this.chk_cricket.Size = new System.Drawing.Size(73, 21);
            this.chk_cricket.TabIndex = 1;
            this.chk_cricket.Text = "Cricket";
            this.chk_cricket.UseVisualStyleBackColor = true;
            this.chk_cricket.CheckedChanged += new System.EventHandler(this.chk_cricket_CheckedChanged);
            // 
            // chk_hochey
            // 
            this.chk_hochey.AutoSize = true;
            this.chk_hochey.Location = new System.Drawing.Point(113, 95);
            this.chk_hochey.Name = "chk_hochey";
            this.chk_hochey.Size = new System.Drawing.Size(78, 21);
            this.chk_hochey.TabIndex = 2;
            this.chk_hochey.Text = "Hochey";
            this.chk_hochey.UseVisualStyleBackColor = true;
            this.chk_hochey.CheckedChanged += new System.EventHandler(this.chk_hochey_CheckedChanged);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(110, 167);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(0, 17);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 441);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.chk_hochey);
            this.Controls.Add(this.chk_cricket);
            this.Controls.Add(this.chk_carrom);
            this.Name = "Form1";
            this.Text = "Checkbox demo 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_carrom;
        private System.Windows.Forms.CheckBox chk_cricket;
        private System.Windows.Forms.CheckBox chk_hochey;
        private System.Windows.Forms.Label lbl_data;
    }
}

