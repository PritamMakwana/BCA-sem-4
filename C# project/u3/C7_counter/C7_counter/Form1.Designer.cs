namespace C7_counter
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
            this.lbl_click = new System.Windows.Forms.Label();
            this.btn_click = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_click
            // 
            this.lbl_click.AutoSize = true;
            this.lbl_click.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_click.ForeColor = System.Drawing.Color.Purple;
            this.lbl_click.Location = new System.Drawing.Point(73, 130);
            this.lbl_click.Name = "lbl_click";
            this.lbl_click.Size = new System.Drawing.Size(134, 17);
            this.lbl_click.TabIndex = 0;
            this.lbl_click.Text = "you have clicked for";
            // 
            // btn_click
            // 
            this.btn_click.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_click.Location = new System.Drawing.Point(213, 130);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(139, 23);
            this.btn_click.TabIndex = 1;
            this.btn_click.Text = "0";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // times
            // 
            this.times.AutoSize = true;
            this.times.Cursor = System.Windows.Forms.Cursors.Default;
            this.times.ForeColor = System.Drawing.Color.Purple;
            this.times.Location = new System.Drawing.Point(352, 130);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(34, 17);
            this.times.TabIndex = 0;
            this.times.Text = "time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(574, 570);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.times);
            this.Controls.Add(this.lbl_click);
            this.Name = "Form1";
            this.Text = "Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_click;
        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Label times;
    }
}

