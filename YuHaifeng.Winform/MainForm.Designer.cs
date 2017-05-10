namespace YuHaifeng.Winform
{
    partial class MainForm
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
            this.ReadFolderBtn = new System.Windows.Forms.Button();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadFolderBtn
            // 
            this.ReadFolderBtn.Location = new System.Drawing.Point(13, 13);
            this.ReadFolderBtn.Name = "ReadFolderBtn";
            this.ReadFolderBtn.Size = new System.Drawing.Size(259, 23);
            this.ReadFolderBtn.TabIndex = 0;
            this.ReadFolderBtn.Text = "读取目录文件列表";
            this.ReadFolderBtn.UseVisualStyleBackColor = true;
            this.ReadFolderBtn.Click += new System.EventHandler(this.ReadFolderBtn_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(13, 53);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(259, 23);
            this.replaceBtn.TabIndex = 1;
            this.replaceBtn.Text = "批量替换文件";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 351);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.ReadFolderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "主窗口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadFolderBtn;
        private System.Windows.Forms.Button replaceBtn;
    }
}

