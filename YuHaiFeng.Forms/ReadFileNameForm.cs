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
    public partial class ReadFileNameForm : Form
    {
        public ReadFileNameForm()
        {
            InitializeComponent();
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            this.folderText.Text = FileHelper.SelectFolder(this.folderText.Text);
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            this.saveFileText.Text = FileHelper.SaveFile("Excel文件(*.xls)|*.xls","请选择保存文件",this.saveFileText.Text);
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.folderText.Text))
            {
                MessageBox.Show("请选择目录");
                return;
            }
            var filter = this.filterCombox.SelectedItem == null ? this.filterCombox.Text : this.filterCombox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(filter))
            {
                MessageBox.Show("请选择文件类型");
                return;
            }
            if (string.IsNullOrEmpty(this.saveFileText.Text))
            {
                MessageBox.Show("请选择保存文件路径");
                return;
            }
            this.ReadBtn.Text = "正在分析生成";
            this.ReadBtn.Enabled = false;
            var tool = new ReadFileNameTool() { Folder = this.folderText.Text, Filter = filter, SaveFilePath = this.saveFileText.Text };
            tool.Program();
            this.ReadBtn.Text = "分析";
            this.ReadBtn.Enabled = true;
            MessageBox.Show("完成");
        }
    }
}
