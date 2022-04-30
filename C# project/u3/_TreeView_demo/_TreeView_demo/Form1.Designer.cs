namespace _TreeView_demo
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
            this.btn_expand = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Collapse = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btn_expand
            // 
            this.btn_expand.Location = new System.Drawing.Point(246, 224);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(75, 23);
            this.btn_expand.TabIndex = 0;
            this.btn_expand.Text = "Expand";
            this.btn_expand.UseVisualStyleBackColor = true;
            this.btn_expand.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(140, 224);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Collapse
            // 
            this.btn_Collapse.Location = new System.Drawing.Point(140, 253);
            this.btn_Collapse.Name = "btn_Collapse";
            this.btn_Collapse.Size = new System.Drawing.Size(75, 23);
            this.btn_Collapse.TabIndex = 0;
            this.btn_Collapse.Text = "Collapse";
            this.btn_Collapse.UseVisualStyleBackColor = true;
            this.btn_Collapse.Click += new System.EventHandler(this.btn_Collapse_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(246, 253);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_sort.TabIndex = 0;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(140, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(182, 149);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 362);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_Collapse);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_expand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_expand;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Collapse;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TreeView treeView1;
    }
}

