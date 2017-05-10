using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YuHaiFeng.Commons;
using YuHaiFeng.Tools;

namespace YuHaiFeng.Forms
{
    public partial class ReplaceForm : Form
    {
        public ReplaceForm()
        {
            InitializeComponent();
        }

        private void ReplaceBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.SourcetextBox.Text))
            {
                MessageBox.Show("请输入原始文件");
                return;
            }
            if (string.IsNullOrEmpty(this.KeyTxt.Text))
            {
                MessageBox.Show("请输入替换关键字");
                return;
            }
            if (string.IsNullOrEmpty(this.ReplaceFiletextBox.Text))
            {
                MessageBox.Show("请选择替换内容文件");
                return;
            }

            if (string.IsNullOrEmpty(this.SaveFiletextBox.Text))
            {
                MessageBox.Show("请选择保存文件路径");
                return;
            }
            this.ReplaceBtn.Text = "正在替换";
            this.ReplaceBtn.Enabled = false;
            var tool = new ReplaceTool() { SourceTxt = this.SourcetextBox.Text, Key = this.KeyTxt.Text, ReplaceFile = this.ReplaceFiletextBox.Text, SaveFile = this.SaveFiletextBox.Text };
            tool.Program();
            this.ReplaceBtn.Text = "替换";
            this.ReplaceBtn.Enabled = true;
            MessageBox.Show("完成");
        }

        private void filebtn_Click(object sender, EventArgs e)
        {
            this.SaveFiletextBox.Text = FileHelper.SaveFile("文本文件（*.txt）|*.txt","请选择保存文件", this.SaveFiletextBox.Text);
        }

        private void replaceFileBtn_Click(object sender, EventArgs e)
        {
            this.ReplaceFiletextBox.Text = FileHelper.OpenFile("请选择替换内容文件", "Excel文件（*.xls）|*.xls", this.ReplaceFiletextBox.Text);
        }
    }
}
