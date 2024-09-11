namespace BackGroundWorkerApp
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
            this.btnSyncronius = new System.Windows.Forms.Button();
            this.btnAsyncrounius = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSyncronius
            // 
            this.btnSyncronius.Location = new System.Drawing.Point(74, 24);
            this.btnSyncronius.Name = "btnSyncronius";
            this.btnSyncronius.Size = new System.Drawing.Size(204, 56);
            this.btnSyncronius.TabIndex = 0;
            this.btnSyncronius.Text = "btnSyncronius";
            this.btnSyncronius.UseVisualStyleBackColor = true;
            this.btnSyncronius.Click += new System.EventHandler(this.btnSyncronius_Click);
            // 
            // btnAsyncrounius
            // 
            this.btnAsyncrounius.Location = new System.Drawing.Point(389, 24);
            this.btnAsyncrounius.Name = "btnAsyncrounius";
            this.btnAsyncrounius.Size = new System.Drawing.Size(259, 56);
            this.btnAsyncrounius.TabIndex = 1;
            this.btnAsyncrounius.Text = "btnAsyncrounius";
            this.btnAsyncrounius.UseVisualStyleBackColor = true;
            this.btnAsyncrounius.Click += new System.EventHandler(this.btnAsyncrounius_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 320);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(574, 41);
            this.progressBar1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(74, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(574, 147);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAsyncrounius);
            this.Controls.Add(this.btnSyncronius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSyncronius;
        private System.Windows.Forms.Button btnAsyncrounius;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

