using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YuHaiFeng.Forms;

namespace YuHaifeng.Winform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ReadFolderBtn_Click(object sender, EventArgs e)
        {
            var form = new ReadFileNameForm();
            form.ShowDialog(this);
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            var form = new ReplaceForm();
            form.ShowDialog(this);
        }
    }
}
