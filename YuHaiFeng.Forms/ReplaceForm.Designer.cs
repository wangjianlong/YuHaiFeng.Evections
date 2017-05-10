namespace YuHaiFeng.Forms
{
    partial class ReplaceForm
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
            this.SourcetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceFileBtn = new System.Windows.Forms.Button();
            this.ReplaceFiletextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplaceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyTxt = new System.Windows.Forms.TextBox();
            this.savefilebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveFiletextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SourcetextBox
            // 
            this.SourcetextBox.Location = new System.Drawing.Point(95, 12);
            this.SourcetextBox.Multiline = true;
            this.SourcetextBox.Name = "SourcetextBox";
            this.SourcetextBox.Size = new System.Drawing.Size(323, 106);
            this.SourcetextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "原始文本：";
            // 
            // replaceFileBtn
            // 
            this.replaceFileBtn.Location = new System.Drawing.Point(371, 201);
            this.replaceFileBtn.Name = "replaceFileBtn";
            this.replaceFileBtn.Size = new System.Drawing.Size(47, 23);
            this.replaceFileBtn.TabIndex = 7;
            this.replaceFileBtn.Text = "...";
            this.replaceFileBtn.UseVisualStyleBackColor = true;
            this.replaceFileBtn.Click += new System.EventHandler(this.replaceFileBtn_Click);
            // 
            // ReplaceFiletextBox
            // 
            this.ReplaceFiletextBox.Location = new System.Drawing.Point(95, 201);
            this.ReplaceFiletextBox.Name = "ReplaceFiletextBox";
            this.ReplaceFiletextBox.ReadOnly = true;
            this.ReplaceFiletextBox.Size = new System.Drawing.Size(270, 21);
            this.ReplaceFiletextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "替换文件：";
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Location = new System.Drawing.Point(95, 299);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplaceBtn.TabIndex = 8;
            this.ReplaceBtn.Text = "替换";
            this.ReplaceBtn.UseVisualStyleBackColor = true;
            this.ReplaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "替换关键字：";
            // 
            // KeyTxt
            // 
            this.KeyTxt.Location = new System.Drawing.Point(95, 130);
            this.KeyTxt.Multiline = true;
            this.KeyTxt.Name = "KeyTxt";
            this.KeyTxt.Size = new System.Drawing.Size(323, 65);
            this.KeyTxt.TabIndex = 1;
            // 
            // savefilebtn
            // 
            this.savefilebtn.Location = new System.Drawing.Point(371, 249);
            this.savefilebtn.Name = "savefilebtn";
            this.savefilebtn.Size = new System.Drawing.Size(47, 23);
            this.savefilebtn.TabIndex = 2;
            this.savefilebtn.Text = "...";
            this.savefilebtn.UseVisualStyleBackColor = true;
            this.savefilebtn.Click += new System.EventHandler(this.filebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "保存文件：";
            // 
            // SaveFiletextBox
            // 
            this.SaveFiletextBox.Location = new System.Drawing.Point(95, 250);
            this.SaveFiletextBox.Name = "SaveFiletextBox";
            this.SaveFiletextBox.ReadOnly = true;
            this.SaveFiletextBox.Size = new System.Drawing.Size(270, 21);
            this.SaveFiletextBox.TabIndex = 10;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 334);
            this.Controls.Add(this.SaveFiletextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReplaceBtn);
            this.Controls.Add(this.replaceFileBtn);
            this.Controls.Add(this.ReplaceFiletextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SourcetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savefilebtn);
            this.Controls.Add(this.KeyTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReplaceForm";
            this.Text = "3批量";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SourcetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button replaceFileBtn;
        private System.Windows.Forms.TextBox ReplaceFiletextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReplaceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyTxt;
        private System.Windows.Forms.Button savefilebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SaveFiletextBox;
    }
}