namespace C6_maths
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_sign = new System.Windows.Forms.TextBox();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ans";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Y";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(179, 80);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(249, 22);
            this.txt_x.TabIndex = 1;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(179, 130);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(249, 22);
            this.txt_y.TabIndex = 2;
            // 
            // txt_sign
            // 
            this.txt_sign.Location = new System.Drawing.Point(179, 174);
            this.txt_sign.Name = "txt_sign";
            this.txt_sign.ShortcutsEnabled = false;
            this.txt_sign.Size = new System.Drawing.Size(249, 22);
            this.txt_sign.TabIndex = 3;
            this.txt_sign.TextChanged += new System.EventHandler(this.txt_sign_TextChanged);
            // 
            // txt_ans
            // 
            this.txt_ans.Location = new System.Drawing.Point(179, 223);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.ReadOnly = true;
            this.txt_ans.Size = new System.Drawing.Size(249, 22);
            this.txt_ans.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(931, 615);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.txt_sign);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "maths";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_sign;
        private System.Windows.Forms.TextBox txt_ans;
    }
}

