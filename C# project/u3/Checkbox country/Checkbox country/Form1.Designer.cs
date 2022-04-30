namespace Checkbox_country
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
            this.chk_india = new System.Windows.Forms.CheckBox();
            this.chk_russia = new System.Windows.Forms.CheckBox();
            this.chk_australia = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_india
            // 
            this.chk_india.AutoSize = true;
            this.chk_india.Location = new System.Drawing.Point(77, 45);
            this.chk_india.Name = "chk_india";
            this.chk_india.Size = new System.Drawing.Size(60, 21);
            this.chk_india.TabIndex = 0;
            this.chk_india.Text = "India";
            this.chk_india.UseVisualStyleBackColor = true;
            this.chk_india.CheckedChanged += new System.EventHandler(this.chk_india_CheckedChanged);
            // 
            // chk_russia
            // 
            this.chk_russia.AutoSize = true;
            this.chk_russia.Location = new System.Drawing.Point(255, 45);
            this.chk_russia.Name = "chk_russia";
            this.chk_russia.Size = new System.Drawing.Size(73, 21);
            this.chk_russia.TabIndex = 1;
            this.chk_russia.Text = "Russia";
            this.chk_russia.UseVisualStyleBackColor = true;
            this.chk_russia.CheckedChanged += new System.EventHandler(this.chk_russia_CheckedChanged);
            // 
            // chk_australia
            // 
            this.chk_australia.AutoSize = true;
            this.chk_australia.Location = new System.Drawing.Point(424, 45);
            this.chk_australia.Name = "chk_australia";
            this.chk_australia.Size = new System.Drawing.Size(85, 21);
            this.chk_australia.TabIndex = 2;
            this.chk_australia.Text = "Australia";
            this.chk_australia.UseVisualStyleBackColor = true;
            this.chk_australia.CheckedChanged += new System.EventHandler(this.chk_australia_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "You have selected :";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(77, 161);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(0, 17);
            this.lbl_data.TabIndex = 4;
            this.lbl_data.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 605);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_australia);
            this.Controls.Add(this.chk_russia);
            this.Controls.Add(this.chk_india);
            this.Name = "Form1";
            this.Text = "Check country";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_india;
        private System.Windows.Forms.CheckBox chk_russia;
        private System.Windows.Forms.CheckBox chk_australia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_data;
    }
}

