namespace YuHaiFeng.Forms
{
    partial class ReadFileNameForm
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
            this.folderText = new System.Windows.Forms.TextBox();
            this.folderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filterCombox = new System.Windows.Forms.ComboBox();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.saveFileText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目录：";
            // 
            // folderText
            // 
            this.folderText.Location = new System.Drawing.Point(79, 24);
            this.folderText.Name = "folderText";
            this.folderText.ReadOnly = true;
            this.folderText.Size = new System.Drawing.Size(237, 21);
            this.folderText.TabIndex = 1;
            // 
            // folderBtn
            // 
            this.folderBtn.Location = new System.Drawing.Point(323, 21);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(49, 23);
            this.folderBtn.TabIndex = 2;
            this.folderBtn.Text = "...";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件类型：";
            // 
            // filterCombox
            // 
            this.filterCombox.FormattingEnabled = true;
            this.filterCombox.Items.AddRange(new object[] {
            "*.doc",
            "*.txt",
            "*.xls",
            "*.xlsx",
            "*.dwg",
            "*.dxf"});
            this.filterCombox.Location = new System.Drawing.Point(79, 66);
            this.filterCombox.Name = "filterCombox";
            this.filterCombox.Size = new System.Drawing.Size(56, 20);
            this.filterCombox.TabIndex = 5;
            this.filterCombox.Text = "*.*";
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(323, 99);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(49, 23);
            this.saveFileBtn.TabIndex = 8;
            this.saveFileBtn.Text = "...";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // saveFileText
            // 
            this.saveFileText.Location = new System.Drawing.Point(79, 102);
            this.saveFileText.Name = "saveFileText";
            this.saveFileText.ReadOnly = true;
            this.saveFileText.Size = new System.Drawing.Size(237, 21);
            this.saveFileText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "文件名：";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(79, 215);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 9;
            this.ReadBtn.Text = "分析";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // ReadFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 250);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.saveFileText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterCombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.folderText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReadFileNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读取文件夹文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderText;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterCombox;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.TextBox saveFileText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReadBtn;
    }
}