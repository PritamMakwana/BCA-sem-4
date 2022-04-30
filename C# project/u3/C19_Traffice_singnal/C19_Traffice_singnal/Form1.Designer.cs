namespace C19_Traffice_singnal
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
            this.components = new System.ComponentModel.Container();
            this.lbl_stop = new System.Windows.Forms.Label();
            this.lbl_strat = new System.Windows.Forms.Label();
            this.lbl_wait = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_stop
            // 
            this.lbl_stop.AutoSize = true;
            this.lbl_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stop.Location = new System.Drawing.Point(257, 52);
            this.lbl_stop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(88, 31);
            this.lbl_stop.TabIndex = 0;
            this.lbl_stop.Text = "STOP";
            // 
            // lbl_strat
            // 
            this.lbl_strat.AutoSize = true;
            this.lbl_strat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_strat.Location = new System.Drawing.Point(257, 138);
            this.lbl_strat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_strat.Name = "lbl_strat";
            this.lbl_strat.Size = new System.Drawing.Size(104, 31);
            this.lbl_strat.TabIndex = 0;
            this.lbl_strat.Text = "START";
            this.lbl_strat.Click += new System.EventHandler(this.lbl_strat_Click);
            // 
            // lbl_wait
            // 
            this.lbl_wait.AutoSize = true;
            this.lbl_wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wait.Location = new System.Drawing.Point(263, 97);
            this.lbl_wait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_wait.Name = "lbl_wait";
            this.lbl_wait.Size = new System.Drawing.Size(82, 31);
            this.lbl_wait.TabIndex = 0;
            this.lbl_wait.Text = "WAIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "STATUS :";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(335, 313);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 31);
            this.lbl_status.TabIndex = 2;
            // 
            // btn_on
            // 
            this.btn_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_on.Location = new System.Drawing.Point(155, 210);
            this.btn_on.Margin = new System.Windows.Forms.Padding(4);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(136, 46);
            this.btn_on.TabIndex = 3;
            this.btn_on.Text = "ON";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // btn_off
            // 
            this.btn_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_off.Location = new System.Drawing.Point(301, 210);
            this.btn_off.Margin = new System.Windows.Forms.Padding(4);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(136, 46);
            this.btn_off.TabIndex = 3;
            this.btn_off.Text = "OFF";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 556);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_wait);
            this.Controls.Add(this.lbl_strat);
            this.Controls.Add(this.lbl_stop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Traffice Singnal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stop;
        private System.Windows.Forms.Label lbl_strat;
        private System.Windows.Forms.Label lbl_wait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Timer timer1;

        public System.EventHandler lbl_strat_Click { get; set; }
    }
}

