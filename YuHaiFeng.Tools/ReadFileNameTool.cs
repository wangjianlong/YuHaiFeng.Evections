using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YuHaiFeng.Commons;

namespace YuHaiFeng.Tools
{
    public class ReadFileNameTool:ITool
    {
        private string _folder { get; set; }
        public string Folder { get { return _folder; }set { _folder = value; } }
        private string _filter { get; set; }
        public string Filter { get { return _filter; } set { _filter = value; } }
        private string _saveFilePath { get; set; }
        public string SaveFilePath { get { return _saveFilePath; }set { _saveFilePath = value; } }

        public void Program()
        {
            if (!System.IO.Directory.Exists(_folder))
            {
                Console.WriteLine(string.Format("目录：{0} 不存在，请核对!", _folder));
                return;
            }
            var files = FileHelper.GetSpecialFiles(_folder,_filter);
            if (files == null || files.Count == 0)
            {
                Console.WriteLine(string.Format("当前目录：【{0}】下不存在类型为【{1}】的文件", _folder, _filter));
                return;
            }
            _saveFilePath.SaveFiles(files);

        }
    }
}
