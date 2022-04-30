namespace C8_notes
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
            this.txt_f = new System.Windows.Forms.TextBox();
            this.txt_s = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_append = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_f
            // 
            this.txt_f.Location = new System.Drawing.Point(67, 40);
            this.txt_f.Multiline = true;
            this.txt_f.Name = "txt_f";
            this.txt_f.Size = new System.Drawing.Size(422, 60);
            this.txt_f.TabIndex = 1;
            // 
            // txt_s
            // 
            this.txt_s.Location = new System.Drawing.Point(67, 294);
            this.txt_s.Multiline = true;
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(422, 60);
            this.txt_s.TabIndex = 2;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(77, 121);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 38);
            this.btn_copy.TabIndex = 1;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.Location = new System.Drawing.Point(158, 121);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(75, 38);
            this.btn_cut.TabIndex = 1;
            this.btn_cut.Text = "Cut";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.Location = new System.Drawing.Point(77, 165);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(75, 38);
            this.btn_paste.TabIndex = 1;
            this.btn_paste.Text = "Paste";
            this.btn_paste.UseVisualStyleBackColor = true;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_append
            // 
            this.btn_append.Location = new System.Drawing.Point(158, 165);
            this.btn_append.Name = "btn_append";
            this.btn_append.Size = new System.Drawing.Size(114, 38);
            this.btn_append.TabIndex = 1;
            this.btn_append.Text = "Append";
            this.btn_append.UseVisualStyleBackColor = true;
            this.btn_append.Click += new System.EventHandler(this.btn_append_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(110, 220);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 38);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(624, 399);
            this.Controls.Add(this.btn_paste);
            this.Controls.Add(this.btn_append);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.txt_s);
            this.Controls.Add(this.txt_f);
            this.Name = "Form1";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_f;
        private System.Windows.Forms.TextBox txt_s;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_append;
        private System.Windows.Forms.Button btn_clear;
    }
}

