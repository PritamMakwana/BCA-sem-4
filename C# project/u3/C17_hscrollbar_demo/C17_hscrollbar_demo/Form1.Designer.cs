namespace C17_hscrollbar_demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hsb = new System.Windows.Forms.HScrollBar();
            this.txt_mn = new System.Windows.Forms.TextBox();
            this.txt_mx = new System.Windows.Forms.TextBox();
            this.txt_l = new System.Windows.Forms.TextBox();
            this.txt_s = new System.Windows.Forms.TextBox();
            this.txt_v = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "LargeChange";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SmallChange";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Value";
            // 
            // hsb
            // 
            this.hsb.LargeChange = 20;
            this.hsb.Location = new System.Drawing.Point(89, 218);
            this.hsb.Minimum = 1;
            this.hsb.Name = "hsb";
            this.hsb.Size = new System.Drawing.Size(555, 24);
            this.hsb.TabIndex = 1;
            this.hsb.Value = 1;
            this.hsb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_Scroll);
            // 
            // txt_mn
            // 
            this.txt_mn.Location = new System.Drawing.Point(174, 41);
            this.txt_mn.Name = "txt_mn";
            this.txt_mn.Size = new System.Drawing.Size(162, 20);
            this.txt_mn.TabIndex = 2;
            // 
            // txt_mx
            // 
            this.txt_mx.Location = new System.Drawing.Point(174, 72);
            this.txt_mx.Name = "txt_mx";
            this.txt_mx.Size = new System.Drawing.Size(162, 20);
            this.txt_mx.TabIndex = 2;
            // 
            // txt_l
            // 
            this.txt_l.Location = new System.Drawing.Point(174, 98);
            this.txt_l.Name = "txt_l";
            this.txt_l.Size = new System.Drawing.Size(162, 20);
            this.txt_l.TabIndex = 2;
            // 
            // txt_s
            // 
            this.txt_s.Location = new System.Drawing.Point(174, 124);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(162, 20);
            this.txt_s.TabIndex = 2;
            // 
            // txt_v
            // 
            this.txt_v.Location = new System.Drawing.Point(174, 147);
            this.txt_v.Name = "txt_v";
            this.txt_v.Size = new System.Drawing.Size(162, 20);
            this.txt_v.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 472);
            this.Controls.Add(this.txt_v);
            this.Controls.Add(this.txt_s);
            this.Controls.Add(this.txt_l);
            this.Controls.Add(this.txt_mx);
            this.Controls.Add(this.txt_mn);
            this.Controls.Add(this.hsb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsb;
        private System.Windows.Forms.TextBox txt_mn;
        private System.Windows.Forms.TextBox txt_mx;
        private System.Windows.Forms.TextBox txt_l;
        private System.Windows.Forms.TextBox txt_s;
        private System.Windows.Forms.TextBox txt_v;
    }
}

