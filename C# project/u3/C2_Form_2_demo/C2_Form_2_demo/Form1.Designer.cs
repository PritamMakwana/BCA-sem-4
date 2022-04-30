namespace C2_Form_2_demo
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
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_second = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_first
            // 
            this.txt_first.Location = new System.Drawing.Point(185, 79);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(456, 22);
            this.txt_first.TabIndex = 0;
            this.txt_first.Enter += new System.EventHandler(this.txt_first_Enter);
            this.txt_first.Leave += new System.EventHandler(this.txt_first_Leave);
            // 
            // txt_second
            // 
            this.txt_second.Location = new System.Drawing.Point(185, 128);
            this.txt_second.Name = "txt_second";
            this.txt_second.Size = new System.Drawing.Size(456, 22);
            this.txt_second.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 554);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.TextBox txt_second;
    }
}

