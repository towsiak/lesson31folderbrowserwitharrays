namespace lesson31folderbrowserwitharrays
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
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnListFiles = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtFolderPath.Location = new System.Drawing.Point(13, 13);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(1091, 53);
            this.txtFolderPath.TabIndex = 0;
            this.txtFolderPath.DoubleClick += new System.EventHandler(this.txtFolderPath_DoubleClick);
            // 
            // btnListFiles
            // 
            this.btnListFiles.Enabled = false;
            this.btnListFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnListFiles.Location = new System.Drawing.Point(12, 81);
            this.btnListFiles.Name = "btnListFiles";
            this.btnListFiles.Size = new System.Drawing.Size(214, 60);
            this.btnListFiles.TabIndex = 1;
            this.btnListFiles.Text = "List Files";
            this.btnListFiles.UseVisualStyleBackColor = true;
            this.btnListFiles.Click += new System.EventHandler(this.btnListFiles_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.richTextBox1.Location = new System.Drawing.Point(13, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1091, 515);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 694);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnListFiles);
            this.Controls.Add(this.txtFolderPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnListFiles;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

